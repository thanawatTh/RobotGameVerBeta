﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeforeScene : MonoBehaviour
{
    private int beforetSceneToLoad;
    public GameObject healthPlayer;
    // Start is called before the first frame update
    void Start()
    {
        beforetSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(beforetSceneToLoad);
            DontDestroyOnLoad(healthPlayer);
        }
    }

}
