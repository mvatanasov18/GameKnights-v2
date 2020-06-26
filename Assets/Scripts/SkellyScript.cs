using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkellyScript : MonoBehaviour
{
   public float healthAmount;

    void Start()
    {
        healthAmount = 0.4f;
    }

    void Update()
    {
        if(healthAmount<=0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        healthAmount -= 0.2f;
    }
}
