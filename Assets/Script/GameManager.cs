using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    public GameObject gameOver;
    public GameObject pauseGameObj;
    public HealthContorller healthBar;
    public HealthEnamyContorller healthEnamy;
    [HideInInspector]
    public bool pause;
    #region Signleton
    public static GameManager instance;
    public GameObject winGame;
   
    public GameObject main;
    public bool loadNewScene = false;
    //public EvilEyeController evil;
    bool wingameBool = false;


    private void Start()
    {
       
        gameOver.SetActive(false);
        pauseGameObj.SetActive(false);
        pause = false;
        Time.timeScale = 1;
        winGame.SetActive(false);
    }
    void Awake()
    {
        instance = this;
    }



    #endregion

    private void Update()
    {
        if (healthBar.isDie == true)
        {

            gameOver.SetActive(true);

        }
        else
        {
            Time.timeScale = 1;
        }

        if (healthEnamy.healthEvilEye <= 0)
        {
            Invoke("WinGame", 2f);

            if (wingameBool == true)
            {
                Invoke("StopTime", 1f);
                Time.timeScale= 0;
            }
        }
       
        
    }

  

    public void nextScene()
    {
        SceneManager.LoadScene("LVL01");
    }



    public void Reset()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        healthBar.isDie = false;
        SoundManager.instance.ButtonClick();
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");

        SoundManager.instance.ButtonClick();
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pause = true;
            pauseGameObj.SetActive(true);
            SoundManager.instance.ButtonClick();

        }
       
               
    }

    public void Continue()
    {
        
            Time.timeScale = 1;
            pause = false;
            pauseGameObj.SetActive(false);
            SoundManager.instance.ButtonClick();
    }


   public void WinGame()
    {
        winGame.SetActive(true);
        wingameBool = true;
    }

    public void StopTime()
    {
        Time.timeScale = 0;
    }

}
