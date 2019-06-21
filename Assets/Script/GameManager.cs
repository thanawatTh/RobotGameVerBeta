using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject gameOver;
    public HealthContorller healthBar;
    #region Signleton
    public static GameManager instance;
   
    public GameObject main;
    public bool loadNewScene = false;



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

}
