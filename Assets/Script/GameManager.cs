using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    #region Signleton
    public static GameManager instance;
    public HealthContorller healthBar;
    public GameObject main;
    public bool loadNewScene = false;
    public GameObject gameOver;


    private void Start()
    {
        gameHasEnded = false;
        gameOver.SetActive(false);
    }
    void Awake()
    {
        instance = this;
    }



    #endregion

    private void Update()
    {
        
    }

   // public void EndGame()
   // {     
   //    if (gameHasEnded == false)
   //     {
   //         gameHasEnded = true;
   //         Debug.Log("GAME OVER");
   //         Invoke("Reset", 2f);
   //     }
        
       
   // }

   //public void Reset()
   // {
   //     Time.timeScale = 1;
   //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   // }

    public void nextScene()
    {
        SceneManager.LoadScene("LVL01");
    }


    public void EndGame()
    {
        if (healthBar.health <= 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);

        }
    }


    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
