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
    [SerializeField] private float tMax = 2.5f;

    //Pontuacao
    [SerializeField] private Text pontosTexto;

    private float pontos = 0f;

    //Variavel do level
    private int level = 1;
    [SerializeField] private Text levelTexto;
    [SerializeField] private float proximoLevel = 10f;

    //Variaveis do som
    [SerializeField] private AudioClip levelUp;
    private Vector3 camPos;
    
    // Start is called before the first frame update
    void Start()
    {
        camPos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Pontuar();

        //Criando obstaculos aleatoriamente
        CriaObstaculo();

        GanhaLevel();
    }

    //Ganhando level
    private void GanhaLevel()
    {


        //Debug.Log(level);

        levelTexto.text = level.ToString();

        if(pontos > proximoLevel)
        {
            
            AudioSource.PlayClipAtPoint(levelUp, camPos);

            level++;
            proximoLevel *= 2;
        }
    }

    private void Pontuar()
    {
        pontos += Time.deltaTime * level;
       
        pontosTexto.text = Mathf.Round(pontos).ToString();
        
        //Debug.Log(Mathf.Round(pontos));
    }

    private void CriaObstaculo()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            //Debug.Log("Oi");

            timer = Random.Range(tMin / level, tMax);


            posicao.y = Random.Range(posMin, posMax);

            Instantiate(obstaculo, posicao, Quaternion.identity);


        }
    }

    public int RetornaLevel()
    {
        return level;
    }

}
