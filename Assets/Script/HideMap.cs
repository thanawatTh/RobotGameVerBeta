using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideMap : MonoBehaviour
{

    public GameObject hideMapButton;


    public void Start()
    {
        hideMapButton.SetActive(false);
    }

    public void Show()
    {
        hideMapButton.SetActive(true);
    }

    public void Hide()
    {
        hideMapButton.SetActive(false);
    }


    public void GotoMap2()
    {
        SceneManager.LoadScene("LVL02");
    }

    public void GotoMap3()
    {
        SceneManager.LoadScene("LVL03");
    }

    public void GotoMap4()
    {
        SceneManager.LoadScene("LVL04");
    }

    public void GotoMap5()
    {
        SceneManager.LoadScene("LVL05");
    }
}
