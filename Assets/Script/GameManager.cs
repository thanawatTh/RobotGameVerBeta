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
    int count;
    [HideInInspector]
    public bool pause;
    #region Signleton
    public static GameManager instance;
   
    public GameObject main;
    public bool loadNewScene = false;
    //public EvilEyeController evil;



    private void Start()
    {
       
        gameOver.SetActive(false);
        pauseGameObj.SetActive(false);
        pause = false;
        Time.timeScale = 1;
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
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pause = true;
            pauseGameObj.SetActive(true);
            
            
        }
       
               
    }

    public void Continue()
    {
        
            Time.timeScale = 1;
            pause = false;
            pauseGameObj.SetActive(false);
        
    }


   public void WinGame()
    {

    }

}
