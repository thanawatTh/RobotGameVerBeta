using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public Image healthUi;


    private void Start()
    {
        healthUi = GameObject.Find("HealthBG").GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 image = Camera.main.WorldToScreenPoint(this.transform.position);
        healthUi.transform.position = image;
    }
}
