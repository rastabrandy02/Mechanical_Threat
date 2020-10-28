using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour

{
    public float velocidadx = 10f;
    public bool mirandoDerecha = true;
    public float jumpForce = 30f;
    bool jump = false;
    public Transform pie;
    public LayerMask suelo;
    public bool estaenelsuelo = false;
    public float radiopie = 0.4f;
    public Animator animator;

    public int maxHealth = 100;
    public int health;

    public HealthBar healthBar;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(inputX * velocidadx));

        if (Input.GetKeyDown(KeyCode.Space) && estaenelsuelo)
        {
            jump = true;

            estaenelsuelo = false;

        }


    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        float movimientoX = inputX * velocidadx;
        estaenelsuelo = Physics2D.OverlapCircle(pie.position, radiopie, suelo);


        float velocidady = gameObject.GetComponent<Rigidbody2D>().velocity.y;

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(movimientoX, velocidady, 0);

        if (inputX < 0 && mirandoDerecha)
        {
            girarIzquierda();
        }
        else if (inputX > 0 && !mirandoDerecha)
        {
            girarDerecha();
        }

        if (jump)
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = false;

        }

        if (estaenelsuelo == false)
        {
            animator.SetBool("Suelo", false);
        }
        if (estaenelsuelo == true)
        {
            animator.SetBool("Suelo", true);
        }
    }
    void girarIzquierda()
    {
        mirandoDerecha = !mirandoDerecha;
        transform.localScale = new Vector3(-1, 1, 1);
    }
    void girarDerecha()
    {
        mirandoDerecha = !mirandoDerecha;
        transform.localScale = new Vector3(1, 1, 1);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }

    }
    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        SceneManager.LoadScene("PantallaMuerte");
    }

    public void TakeHeal(int heal)
    {
        health += heal;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        healthBar.SetHealth(health);
    }
}

