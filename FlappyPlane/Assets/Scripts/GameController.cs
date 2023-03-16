using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private float timer = 1.3f;

    [SerializeField] private GameObject obstaculo;

    [SerializeField] private Vector3 posicao;
   
    //Posicoes minimas e maximas dos obstaculos
    [SerializeField] private float posMin = -0.4f;
    [SerializeField] private float posMax = 2.4f;
    
    //Variáveis de tempo
    [SerializeField] private float tMin = 1f;
    [SerializeField] private float tMax = 3f;

    //Pontuacao
    [SerializeField] private Text pontosTexto;

    private float pontos = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pontuar();

        //Criando obstaculos aleatoriamente
        CriaObstaculo();
    }

    private void Pontuar()
    {
        pontos += Time.deltaTime;
       
        pontosTexto.text = Mathf.Round(pontos).ToString();
        
        Debug.Log(Mathf.Round(pontos));
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Debug.Log("Oi");

            timer = Random.Range(tMin, tMax);


            posicao.y = Random.Range(posMin, posMax);

            Instantiate(obstaculo, posicao, Quaternion.identity);


        }
    }
}
