using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        //SceneManager.LoadScene("BaseScenes", LoadSceneMode.Additive);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("BaseScenes"));
        SceneManager.LoadScene("BaseScenes", LoadSceneMode.Additive);

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
