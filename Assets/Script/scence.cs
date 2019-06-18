using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scence : MonoBehaviour
{

    public GameObject wall;
    public GameObject[] enamy;
    bool opendoor;
    public HealthEnamyContorller healthEnamy;
     

    // Start is called before the first frame update
    void Start()
    {
        wall.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (opendoor)
        {
            SceneManager.LoadScene("LVL02");
        }

       



    }


   

  
}
