using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;
    public static float PlayerHealth;
    public float maxHealth;
    private float timer = 0f;
    public float delayAmount = 1.0f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {
        PlayerHealth = 0.06f;
        maxHealth = 0.06f;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        timer += Time.deltaTime;
        if(timer>=delayAmount)
        {
            timer = 0f;
            PlayerHealth = Mathf.Clamp(PlayerHealth,0.0f,maxHealth);

            if(PlayerHealth<maxHealth && PlayerHealth > 0)
            {
                PlayerHealth += 0.00005f;
            }
            if(PlayerHealth==maxHealth)
            {
                HealthBar.sortingOrder = -5;
            }
        }

        if(PlayerHealth<=0.0f)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Skelly"))
        {
            PlayerHealth -= 0.03f;
            HealthBar.sortingOrder = 100;
        }
    }

}
