using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigoEstudo : MonoBehaviour
{

    public float velocidade = 5.0f;
    public GameObject prefabMeteoro;

    void Start()
    {
        // Debug.Log("Tecla de Espaço");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0.0f, velocidade * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0.0f, -velocidade * Time.deltaTime, 0.0f);
            //transform.position += new Vector3(10.0f, 0.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
        Instantiate(prefabMeteoro, new Vector3 (3.0f, 3.0f, 0.0f), Quaternion.identity);
        }
    }

}
