using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
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
    
   
    void start ()
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
        bool miraIzquierda = robot.GetComponent<Enemy>().miraIzquierda;

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

    /*
    float heading = player.position.x - position;
        if (heading > 0)
        {
            Debug.Log("Estas a la derecha");
            transform.localScale = new Vector3(0.5f, 0.5f, 0f);
    miraIzquierda = false;
        }
        if (heading< 0)
        {
            Debug.Log("Estas a la izquierda");
            transform.localScale = new Vector3(-0.5f, 0.5f, 0f);

        }
       */
        
        


    
    void OnTriggerEnter2D (Collider2D other)
    {
       
        if (other.tag == "Player" )
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
