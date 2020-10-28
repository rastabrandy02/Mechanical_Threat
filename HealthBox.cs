using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBox : MonoBehaviour
{
    
    public Transform potionSpawn;
    public GameObject healthPotion;
   
    void Start()
    {
        
    }


    void Update()
    {
        
    }
    

    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Bullet")
        {
            Die();
        }
        


          
    }
    void Die()
    {

        Instantiate(healthPotion, potionSpawn.position, potionSpawn.rotation);
        Destroy(gameObject);
        
    }
}
