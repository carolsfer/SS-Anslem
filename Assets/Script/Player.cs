using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed; 
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public int health = 3;

    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
        Death();
    }

    void ProcessInputs()
    {
        float moveY = Input.GetAxisRaw("Vertical");
    
        moveDirection = new Vector2(0f, moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(2, moveDirection.y * moveSpeed);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -5f, -0.5f));    
    }

    void Death()
    {
        if (health == 0){
            Destroy(gameObject);
        }
    }
}
