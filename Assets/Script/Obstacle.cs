using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
  
    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            collider.GetComponent<Player>().health -= damage;
            Debug.Log(collider.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}