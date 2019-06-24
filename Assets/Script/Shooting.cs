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
                Boomer health1 = hit.collider.GetComponent<Boomer>();
                BallEnemy health2 = hit.collider.GetComponent<BallEnemy>();
                Enemy health3 = hit.collider.GetComponent<Enemy>();
                EvilEyeController health4 = hit.collider.GetComponent<EvilEyeController>();
                EyeOfEvilL health5 = hit.collider.GetComponent<EyeOfEvilL>();
                Sword health6 = hit.collider.GetComponent<Sword>();
                SwordG health7 = hit.collider.GetComponent<SwordG>();
                Shield health8 = hit.collider.GetComponent<Shield>();


                //E1ball
                if (health != null)
                {

                    health.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }


                //Boomer
                if (health1 != null)
                {

                    health1.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //BallEnemy
                if (health2 != null)
                {

                    health2.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //Enemy
                if (health3 != null)
                {

                    health3.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //BossEvilEye
                if (health4 != null)
                {

                    health4.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //EyeOfEvil
                if (health5 != null)
                {

                    health5.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //Sword
                if (health6 != null)
                {

                    health6.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //SwordG
                if (health7 != null)
                {

                    health7.Damage(gunDamage);
                }


                if (hit.rigidbody != null)
                {

                    hit.rigidbody.AddForce(-hit.normal * hitForce);
                }

                //Shield
                if (health8 != null)
                {

                    health8.Damage(gunDamage);
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

        if (shootingCall == true)
        {
            ShootingStart();
        }
        shootingCall = false;
    }

   
}


