using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    #region Signleton
    public static PlayerManager instance;
    public HealthContorller healthBar;
    public GameObject main;

    void Awake()
    {
        instance = this;
    }

    #endregion


    
   
}
