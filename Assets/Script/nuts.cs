using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuts : MonoBehaviour
{
    public HealthContorller healthContorller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 150 * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            healthContorller.healHp(5);
            Destroy(gameObject, 0.5f);
        }
    }
}
