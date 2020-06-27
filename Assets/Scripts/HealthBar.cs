using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class HealthBar : MonoBehaviour
{
    Vector3 localScale;
    public static int sortingOrder = -5;
    private SpriteRenderer sprite;

    void Start()
    {

        localScale = transform.localScale;
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(sprite)
        {
            sprite.sortingOrder = sortingOrder;
        }
        localScale.x = PlayerController.PlayerHealth;
        transform.localScale = localScale;
    }
}
