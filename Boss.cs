using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int maxHealth = 400;
    private int health;
    public float speed = 5;
    public float stoppingDistance = 13;
    public float retreatDistance = 5;

    private Transform player;
    public Transform shootingPoint;

    private float timeBtwShoots;
    public float startTimeBtwShoots = 5;
    private float timeBtwJumps;
    public float startTimeBtwJumps = 5;
    public GameObject enemybullet;

    public bool miraIzquierda;
    private float heading;




    // public GameObject deathEffect;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShoots = startTimeBtwShoots;
        //startTimeBtwJumps = startTimeBtwJumps;
        health = maxHealth;
    }


    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) >= stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) <= stoppingDistance && Vector2.Distance(transform.position, player.position) >= retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) <= retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }


        if (timeBtwShoots <= 0)
        {
            Instantiate(enemybullet, shootingPoint.position, shootingPoint.rotation);
            timeBtwShoots = startTimeBtwShoots;

        }
        else
        {
            timeBtwShoots -= Time.deltaTime;
        }
        /*

        if(timeBtwJumps <= 0)
        {
            timeBtwJumps = startTimeBtwJumps;
            
        }
        else
        {
            timeBtwJumps -= Time.deltaTime;
        }
        */
        float position = gameObject.transform.position.x;
        float heading = player.position.x - position;
        if (heading > 0)
        {
            Debug.Log("Estas a la derecha");
            transform.localScale = new Vector3(1f, 1f, 0f);
            miraIzquierda = false;
        }
        if (heading < 0)
        {
            Debug.Log("Estas a la izquierda");
            transform.localScale = new Vector3(-1f, 1f, 0f);
            miraIzquierda = true;
        }







    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss getting dmg");

        if (health <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
