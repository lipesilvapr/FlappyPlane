using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1f;

    [SerializeField] private GameObject obstaculo;

    [SerializeField] private Vector3 posicao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Dando oi se timer for menor ou igual a zero
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Debug.Log("Oi");
            timer = 1f;

            Instantiate(obstaculo, posicao, Quaternion.identity);
        }
    }
}
