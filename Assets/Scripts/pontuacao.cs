using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pontuacao : MonoBehaviour
{
    public TMP_Text textoPontos;
    public int pontos;

    void    awake()
    {
        textoPontos.text = "";
        comportamentoAsteroide.EventoAsteroidDestruido += AsteroideFoiDestruido;
    }

    void    OnDestroy()
    {
        comportamentoAsteroide.EventoAsteroidDestruido -= AsteroideFoiDestruido;
    }

    void    AsteroideFoiDestruido()
    {
        pontos += 1;
        Debug.Log("Asteroide Destruído!");
    }

    void    AtualizacaoTextoPontos ()
    {
        textoPontos.text = pontos.ToString();
    }
}