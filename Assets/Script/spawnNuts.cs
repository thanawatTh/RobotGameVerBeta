using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnNuts : MonoBehaviour
{
   
    public Transform position;
    public float fireRate = 10f;
    public Transform[] spawnPoints;
    public float nextFire;
    public GameObject[] cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject spawnedCube = Instantiate(cube[Random.Range(0, 10)], spawnPoint.position, spawnPoint.rotation);

            Destroy(spawnedCube, 10f);

        }
      
    }


}
