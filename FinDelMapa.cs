using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinDelMapa : MonoBehaviour
{

    
    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
           
            print("Fuera del mapa");
            SceneManager.LoadScene("PantallaMuerte");
           
        }
        

    }
}
