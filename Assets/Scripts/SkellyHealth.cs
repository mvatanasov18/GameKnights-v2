using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class SkellyHealth : MonoBehaviour
{
    Vector3 localScale;
    GameObject skelly;
    SkellyScript skelly_1;

    void Start()
    {
        localScale = transform.localScale;
    }

    void Update()
    {
        skelly = GameObject.FindGameObjectWithTag("Skelly");
        skelly_1 = skelly.GetComponent<SkellyScript>();

        localScale.x = skelly_1.healthAmount;
        transform.localScale = localScale;
    }
}
