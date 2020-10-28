using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoint : MonoBehaviour
{ 
    public bool mirandoDerecha = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        if (inputX < 0 && mirandoDerecha)
        {
            girarIzquierda();
        }
        else if (inputX > 0 && !mirandoDerecha)
        {
            girarDerecha();
        }
    }
    void girarIzquierda()
    {
        mirandoDerecha = !mirandoDerecha;
        transform.Rotate(0f, 180f, 0f);
    }
    void girarDerecha()
    {
        mirandoDerecha = !mirandoDerecha;
        transform.Rotate(0f, 180f, 0f);
    }
}
