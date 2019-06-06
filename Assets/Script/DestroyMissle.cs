using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMissle : MonoBehaviour
{

    public ParticleSystem booM;

    // Start is called before the first frame update
    void Start()
    {
        
        Destroy(gameObject, 1.5f);
        Instantiate(booM, transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
