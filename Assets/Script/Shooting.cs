using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public int gunDamage = 1;
    public float fireRate = 0.25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
    private AudioSource gunAudio;
    private LineRenderer laserLine;
    private float nextFire;

    public bool shootingCall;


    void Start()
    {

        laserLine = GetComponent<LineRenderer>();


        gunAudio = GetComponent<AudioSource>();


        fpsCam = GetComponentInParent<Camera>();
    }


    void Update()
    {

        if (shootingCall == true)
        {
            ShootingStart();
        }
        else
        {
            shootingCall = false;
        }

    }

    public void ShootingStart()
    {
        if ( Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;


            StartCoroutine(ShotEffect());


            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));


            RaycastHit hit;


            laserLine.SetPosition(0, gunEnd.position);


            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
            {

                laserLine.SetPosition(1, hit.point);


                E1ball health = hit.collider.GetComponent<E1ball>();


                if (health != null)
                {

                    health.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }
            }

            else
            {

                laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
            }
        }

    }
    private IEnumerator ShotEffect()
    {

        gunAudio.Play();


        laserLine.enabled = true;


        yield return shotDuration;


        laserLine.enabled = false;
    }



    public void ShootingDown()
    {
        shootingCall = true;
    }

    public void ShootingUp()
    {
        shootingCall = false;
    }
}


