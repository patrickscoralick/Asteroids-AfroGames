using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D asteroidRb;
    public float velocidadeMaxima = 1.0f;
    public GameObject projetil;


    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidadeMaxima; //direcao *= velocidadeMaxima;
        asteroidRb.velocity = direcao;
    }

    void    OnTriggerEnter2D (Collider2D projetil)
    {
        Destroy(gameObject);
        Destroy(projetil.gameObject);
    }
}