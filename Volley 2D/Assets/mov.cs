using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{   
    public bool esta_no_chao = false;
    public bool esta_movimentando = false;
    void Start()
    {
    }
    void Update()
    {
        // se não estiver indo nem pra esquerda nem para direita
        if(esta_movimentando == true)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,gameObject.GetComponent<Rigidbody2D>().velocity.y);
            esta_movimentando = false;
        }
        //indo para direita
        if (Input.GetKey("d"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(4,gameObject.GetComponent<Rigidbody2D>().velocity.y);
            esta_movimentando = true;
        }
        //indo para a esquerda
        if (Input.GetKey("a"))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-4,gameObject.GetComponent<Rigidbody2D>().velocity.y);
            esta_movimentando = true;
        }
        //pulando
        if (Input.GetKey("w"))
        {  
            if (esta_no_chao == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 8.5f, 0f);     
            }
        }
    }
    //se estiver em contato com o chão
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
            { 
                esta_no_chao = true;
            }        
    }
    //Se não estiver em contato com o chão
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
        {
            esta_no_chao = false;
        }        
    }



}