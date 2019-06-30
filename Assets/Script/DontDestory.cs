using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestory : MonoBehaviour
{
    public Text text;
    //public GameObject hp;
    //public GameObject player;
    //public GameObject gameManager;
    
    // Start is called before the first frame update
    public void Start()
    {
        if (PlayerPrefs.HasKey("Test")) {
            text.text = PlayerPrefs.GetFloat("Test")+"";
            //text.text = PlayerPrefs.GetFloat("Test")+"";
        }

        //DontDestroyOnLoad(hp);
        //DontDestroyOnLoad(player);
        //DontDestroyOnLoad(gameManager);
    }
    public void SetTest(float test) {
        PlayerPrefs.SetFloat("Test", test);
        text.text = PlayerPrefs.GetFloat("Test") + "";
    }
}
