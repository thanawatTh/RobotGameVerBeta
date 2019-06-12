using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    #region Signleton
    public static GameManager instance;
    public HealthContorller healthBar;
    public GameObject main;



    private void Start()
    {
        gameHasEnded = false;
    }
    void Awake()
    {
        instance = this;
    }


    

    #endregion



    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Reset();
        }
    }

     void Reset()
    {
        SceneManager.LoadScene("LVL01");
    }




}
