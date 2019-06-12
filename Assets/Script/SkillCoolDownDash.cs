using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SkillCoolDownDash : MonoBehaviour
{
    public Image imageCooldown;
    private float cooldown = 1;
    public bool isCooldown;
    public AbilityDash abilityDash;

    void Start()
    {
        abilityDash = GameObject.Find("Body").GetComponent<AbilityDash>();

    }
    // Update is called once per frame
    void Update()
    {
        if (abilityDash.isDashGo == true)
        {
            isCooldown = true;
        }

        if (isCooldown == true)
        {
            imageCooldown.fillAmount += 1 / cooldown * Time.deltaTime;

            if (imageCooldown.fillAmount >= 1)
            {
                imageCooldown.fillAmount = 0;
                isCooldown = false;
                abilityDash.isDashGo = false;
            }
        }

    }


   
}
