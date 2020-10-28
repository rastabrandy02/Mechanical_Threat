using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
    
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 20;


    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Destroy(gameObject);
       Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Boss boss = hitInfo.GetComponent<Boss>();
        if (boss != null)
        {
            boss.TakeDamage(damage);
        }
    }
    
    void Update()
    {
        
    }
}
