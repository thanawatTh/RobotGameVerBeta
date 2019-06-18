using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scence : MonoBehaviour
{

    public GameObject wall;
    public int enamy;
    private List<Boomer> boomers;
    bool removeAll;
    // Start is called before the first frame update
    void Start()
    {
        wall.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (removeAll == true)
        {
            wall.SetActive(true);
            SceneManager.LoadScene("LVL02");
        }
        
       
    }

    public void RemoveFromList(Boomer toRemove)
    {
        if (boomers == null)
        {
            Debug.Log("have boomber");
        }
        else
        {
            boomers.Remove(toRemove);
            if (boomers.Count == 0)
            {
                 removeAll = true;
            }
        }
    }


    //public void AddToList(Boomer enamyToAdd)
    //{
    //    if (boomers == null)
    //    {
    //        boomers = new List<Boomer>();
    //    }
    //    boomers.Add(enamyToAdd);
    //}
}
