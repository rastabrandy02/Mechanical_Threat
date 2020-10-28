using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    public int damage = 20;
    public GameObject robot;
    //private Transform robotTrans;


    //private float robotPos;
    private float playerPos;
    private float heading;
    public string nombre;


    void start()
    {



    }


    void Update()
    {

        Transform robotTrans = robot.transform;
        //robot = GameObject.Find("Enemy 5");
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        float robotPos = robot.transform.position.x;
        //robotPos = robot.transform.position.x;
        heading = (playerPos -= robotPos);
        bool miraIzquierda = robot.GetComponent<Boss>().miraIzquierda;

        if (robot.transform.localScale.x < 0)
        {
            rb.velocity = Vector2.right * -speed;
        }
        else
        {
            rb.velocity = Vector2.right * speed;
        }



        //Debug.Log(robot.transform.localScale.x);
    }



    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            other.GetComponent<Movimiento>().TakeDamage(damage);
            print("Le di");
            Destroy(gameObject);
        }
        if (other.tag == "Bullet")
        {

        }
        else
        {
            Destroy(gameObject);
        }


    }
}
