using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scence : MonoBehaviour
{

    public GameObject wall;
    public int enamy;
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
        
        SceneManager.LoadScene("LVL02");
    }
}
