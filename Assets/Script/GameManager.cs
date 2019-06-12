using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    #region Signleton
    public static GameManager instance;
    public HealthContorller healthBar;
    public GameObject main;

    void Awake()
    {
        instance = this;
    }

    #endregion


    
   
}
