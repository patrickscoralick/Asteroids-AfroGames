using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoAsteroide : MonoBehaviour
{
    public static System.Action EventoAsteroidDestruido = null;

    public Rigidbody2D asteroidRb;
    public comportamentoAsteroide prefabAsteroideMenor;

    public float velocidadeMaxima = 1.0f;
    public GameObject projetil;
    public int  quantidadeFragmentos = 2;


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

        int i;
        i = 0;
        while(i < quantidadeFragmentos)
        {
            Instantiate(prefabAsteroideMenor, asteroidRb.position, Quaternion.identity);
            i = i + 1;
        }
        if (EventoAsteroidDestruido != null)
        {
            EventoAsteroidDestruido();
        }
    }
}