using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor : MonoBehaviour
{
    public GameObject door;
    //public GameObject enamyInScene;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] enamyInScene = GameObject.FindGameObjectsWithTag("TestEnamy");

        //for (int i = 0; i <= enamyInScene.Length; i++)
        //{
        //    Debug.Log(i);
        //}
        Debug.Log("heloo");
        door.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        //GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        //foreach (GameObject enemy in enemies)
        //{

        //}

        GameObject[] enamyInScene = GameObject.FindGameObjectsWithTag("TestEnamy");

        if (enamyInScene.Length == 0)
        {
            Debug.Log("No game objects are tagged with 'Enemy'");
            door.SetActive(true);
        }

    }
}
