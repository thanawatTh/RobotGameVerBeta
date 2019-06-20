using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScence : MonoBehaviour
{
   
    private int nextSceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           
            SceneManager.LoadScene(nextSceneToLoad);
           

        }
    }

    public void Onclick()
    {
        SceneManager.LoadScene(nextSceneToLoad);
      
    }
}
