using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compotarmentoJogador : MonoBehaviour
{
    public float aceleracao = 1.0f;
    public float rotacao = 180.0f;
    public float velocidadeMaxima = 10.0f;
    public Rigidbody2D jogadorRb;

    void Start()
    {
        transform.position = new Vector3 (0.0f, 0.0f, 0.0f);
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * -aceleracao; // Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force); //Adicionar Força na movimentação, efeito mais suavizado!
        }

        if (Input.GetKey(KeyCode.A))
        {
            jogadorRb.rotation += rotacao * Time.deltaTime; //jogadorRb.rotation = jogadorRb.rotation + (180.0f * Time.deltaTime); 
        }

        if (Input.GetKey(KeyCode.D))
        {
            jogadorRb.rotation -= rotacao * Time.deltaTime; //jogadorRb.rotation = jogadorRb.rotation - (180.0f * Time.deltaTime); 
        }

        if (jogadorRb.velocity.magnitude > velocidadeMaxima)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velocidadeMaxima); //Através do Rigidbody controlar a magnitude do objeto
        }

    }
}
