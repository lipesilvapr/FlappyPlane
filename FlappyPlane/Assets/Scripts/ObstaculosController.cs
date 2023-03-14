using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculosController : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Movendo as montanhas para a esquerda
        transform.position += Vector3.left * Time.deltaTime * velocidade;
    }
}
