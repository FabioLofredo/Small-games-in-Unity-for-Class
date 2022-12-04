using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public bool esta_movimentando = false;
    public float velocidade = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // se não estiver indo se movimentando
        if(esta_movimentando == true)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            esta_movimentando = false;
        }
        //indo para direita
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidade,gameObject.GetComponent<Rigidbody2D>().velocity.y);
            esta_movimentando = true;
        }
        //indo para a esquerda 
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-velocidade,gameObject.GetComponent<Rigidbody2D>().velocity.y);
            esta_movimentando = true;
        }
        //indo para cima
            if (Input.GetKey("w"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,velocidade);
            esta_movimentando = true;
        }
        //indo para baixo
            if (Input.GetKey("s"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x,-velocidade);
            esta_movimentando = true;
        }


    }
}