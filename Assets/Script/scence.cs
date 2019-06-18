using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scence : MonoBehaviour
{

    public GameObject wall;
   

    public GameObject[] danger;

    // Start is called before the first frame update
    void Start()
    {
        wall.SetActive(false);
        danger = GameObject.FindGameObjectsWithTag("TestEnamy");
    }

    // Update is called once per frame
    void Update()
    {
        CheackDanger();
    }

    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("LVL02");



    }


    public void CheackDanger()
    {
        //GameObject enmay = GameObject.FindWithTag("TestEnamy");

        //if (enmay != null && danger.Contains(enmay))
        //{
        //    Debug.Log("DangerAll");
        //}


        if (danger != null) 
        {
            Debug.Log("dddddddddddddddddddddddddddddddddd");
        }
    }

  
}
