using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : MonoBehaviour
{


    public int heal = 50;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
           
                other.GetComponent<Movimiento>().TakeHeal(heal);
                Debug.Log("Me curo");
            
           
            Destroy(gameObject);
        }
        

    }
}
