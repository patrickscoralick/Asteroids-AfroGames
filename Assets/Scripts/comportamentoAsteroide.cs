using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoAsteroide : MonoBehaviour
{
    public Rigidbody2D asteroidRb;
    public float velocidadeMaxima = 1.0f;


    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidadeMaxima;
        asteroidRb.velocity = direcao;
    }
}
