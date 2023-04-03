using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{

    private Renderer fundo;

    private float xOffset;

    private Vector2 texturaOffset;

    [SerializeField] private float velocidade = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        fundo = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        xOffset += Time.deltaTime * velocidade;

        texturaOffset.x = xOffset;
        
        fundo.material.mainTextureOffset = texturaOffset;
    }
}
