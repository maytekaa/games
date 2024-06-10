using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoPosicaoY;
    private Vector3 posicaoPassaro;
    private bool pontuei;
    private UIcontroller controladorUI;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoPosicaoY, variacaoPosicaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Personagem>().transform.position;
        this.controladorUI = GameObject.FindObjectOfType<UIcontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        if (!this.pontuei && this.transform.position.x < this.posicaoPassaro.x){
            this.controladorUI.adicionarPontos();
            this.pontuei = true; 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    private void Destruir()
    {
        Destroy(this.gameObject);
    }

}
