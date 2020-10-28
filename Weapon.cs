using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
   
    

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Left Control"))
        {
            shoot();
        }
    }
    void shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
