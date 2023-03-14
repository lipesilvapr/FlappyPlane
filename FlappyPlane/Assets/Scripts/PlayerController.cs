using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D meuRB;

    [SerializeField] private float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //Pegando o rigidbody do aviao
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Subindo ao apertar espaco
        Subir();

        //Limitando a velocidade de queda
        LimitandoVelocidade();
    }

    private void LimitandoVelocidade()
    {
        if (meuRB.velocity.y < -velocidade)
        {
            meuRB.velocity = Vector2.down * velocidade;
        }
    }

    private void Subir()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRB.velocity = Vector2.up * velocidade;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bati!");
        SceneManager.LoadScene(0);    
    }
}
