using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirigir : MonoBehaviour
{

    // Start is called before the first frame update

    //public float velTransl;
    //float x, z;
    public int posicao = 500;
    public float posicaoX, posicaoY, posicaoZ;

    public float rotacaoX, rotacaoY, rotacaoZ;

    public string txt = "test1", txt2 = "test2";
    public bool resposta;

    void Start()
    {
        //velTransl = 4f;

        //posicao = (posicao + (int)posicaoX / (posicao + 2) * 10) - (int)rotacaoX;
        //txt = txt + txt2;
        // = posicao > 10 && posicao < 60;
    }

    // Update is called once per frame
    void Update()
    {
        //vai pra frente e pra traz W & S
        //z = Input.GetAxis("Vertical") * velTransl * Time.deltaTime;
        //vai pra esquerda e direita A & D
        // x = Input.GetAxis("Horizontal") * velTransl * Time.deltaTime;
        // translada o carro
        // transform.Translate(x, 0, z);
        float velAtual = posicaoZ;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            velAtual += posicaoZ;
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, velAtual * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -velAtual * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -rotacaoY * Time.deltaTime, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotacaoY * Time.deltaTime, 0);
        }

    }
}
