using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class chao : MonoBehaviour
{
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;
    private float tamanhoImgCena;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoImg = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoImgCena = tamanhoImg * escala;
    }

    // Update is called once per frame
    void Update()
    {
         float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoImgCena);

        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
