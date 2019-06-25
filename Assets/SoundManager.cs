        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip Bomb;
    static AudioSource audioSource;
    public AudioClip bomb;
    public static SoundManager instance;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //Bomb = Resources.Load<AudioClip>("explosion");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public static void BombSound(string clip)
    //{
    //    //switch (clip)
    //    //{
    //    //    case "explosion":audioSource.PlayOneShot(Bomb);
    //    //        break;
    //    //}
    //    audioSource.PlayOneShot(Bomb);
    //}

    public void Sound()
    {
        Debug.Log("Test");
        audioSource.PlayOneShot(bomb);
    }

}
