using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillCoolDownMissle : MonoBehaviour
{
    public Image imageCooldown;
    public float cooldown = 5;
    public bool isCooldown;
    public Missiles missiles;

    void Start()
    {
        missiles = GetComponent<Missiles>();
        
    }
    // Update is called once per frame
    void Update()
    {
        if (missiles.isMissleGo == true)    
        {
            isCooldown = true;
        }

        if (isCooldown == true )  
        {
            imageCooldown.fillAmount += 1 / cooldown * Time.deltaTime;

            if (imageCooldown.fillAmount >= 1)
            {
                imageCooldown.fillAmount = 0;
                isCooldown = false;
                missiles.isMissleGo = false;
            }
        }

      


    }
}
