using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{

    public float healthEvilEye = 65;
    public Image healthBarBoos;
    public float starHealthBoss;

    // Start is called before the first frame update
    void Start()
    {
        starHealthBoss = healthEvilEye;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damge)
    {
        healthEvilEye = healthEvilEye - damge;
        healthBarBoos.fillAmount = healthEvilEye / starHealthBoss;
    }

}
