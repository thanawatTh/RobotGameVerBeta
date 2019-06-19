using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [HideInInspector]
    public Image healthUi;
    public Text test1;
    public Text test2;
    public Text test3;
    public Text test4;
    public Image test5;
    public Camera testCamera;
    


    private void Start()
    {
        healthUi = GameObject.Find("HealthBG").GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 image = Camera.main.WorldToScreenPoint(this.transform.parent.transform.position);
        Vector3 image2 = testCamera.WorldToScreenPoint(this.transform.parent.transform.position);
        healthUi.rectTransform.position = image;
        test1.rectTransform.position = image;
        test2.rectTransform.anchoredPosition = image;
        test3.rectTransform.anchoredPosition = image2;
        test4.rectTransform.position = image2;
        test5.rectTransform.position = image2;

    }
}
