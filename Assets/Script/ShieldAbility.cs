using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAbility : MonoBehaviour
{

    public GameObject shield;
    public Transform player;

    [HideInInspector]
    public bool showShield;
    public bool isShieldGo;

    // Start is called before the first frame update
    void Start()
    {
        showShield = false;
        shield.SetActive(false);
        shield = GameObject.Find("ShieldObj").GetComponent<GameObject>();
        player = GameObject.Find("Body").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (showShield)
        {
            ShieldStart();
        }
    }


    void ShieldStart()
    {
        shield.SetActive(true);
    }


   public void OnTouchDown()
    {
        showShield = true;
        if (showShield)
        {

        }
    }
}
