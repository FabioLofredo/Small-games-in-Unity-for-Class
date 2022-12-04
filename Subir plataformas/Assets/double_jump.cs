using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class double_jump : MonoBehaviour
{   
    public bool esta_no_chao = false;
    public float tempo_desde_o_ultimo_pulo = 0;
    public int contador_de_pulos = 0;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.Translate(3f* Time.deltaTime, 0, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(-3f * Time.deltaTime, 0, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (Input.GetKey("w"))
        {  
            if (esta_no_chao == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 7f, 0f);
                if(contador_de_pulos == 0) contador_de_pulos = contador_de_pulos + 1; 
            }
            if (esta_no_chao == false && contador_de_pulos == 1 && tempo_desde_o_ultimo_pulo >= 0.5)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 7f, 0f);
                Resetar_pulos();
            }
        }
        if(contador_de_pulos == 1)
        {
            tempo_desde_o_ultimo_pulo += Time.deltaTime;
            if(tempo_desde_o_ultimo_pulo >= 2) 
            {
                Resetar_pulos();
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
            { 
                esta_no_chao = true;
                Resetar_pulos();
            }        
    }
    
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
        {
            esta_no_chao = false;
        }        
    }

    void Resetar_pulos()
    {
        contador_de_pulos = 0; 
        tempo_desde_o_ultimo_pulo = 0; 
    }


}