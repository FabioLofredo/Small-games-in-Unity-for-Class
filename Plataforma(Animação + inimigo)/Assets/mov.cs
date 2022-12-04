using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{   public float teleport_variavel = 0f;
    public bool esta_no_chao = false;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // inicia com parado = true
        anim.SetBool("andar", false);
        anim.SetBool("parado", true);
        anim.SetBool("pular", false);
        // se for para direita, andar = true
        if (Input.GetKey("d"))
        {
            transform.Translate(3f * Time.deltaTime, 0, 0);
            anim.SetBool("andar", true);
            anim.SetBool("parado", false);
            anim.SetBool("pular", false);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        // se for para direita, andar = true
        if (Input.GetKey("a"))
        {
            transform.Translate(-3f * Time.deltaTime, 0, 0);
            anim.SetBool("andar", true);
            anim.SetBool("parado", false);
            anim.SetBool("pular", false);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        // se estiver no ar, pular = true
        if (esta_no_chao == false)
        {
            anim.SetBool("andar", false);
            anim.SetBool("parado", false);
            anim.SetBool("pular", true);
        }

        // pula
        if (Input.GetKey("w"))
        {
            if (esta_no_chao == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 7f, 0f);
            }
        }

    }

    // se estiver no chão
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
        {
            esta_no_chao = true;
        }

    }
    // se não estiver no chão
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
        {
            esta_no_chao = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // mata o inimigo se colidir com a cabeça
        if (col.gameObject.CompareTag("Cabeca_Tag"))
        {   // destroi o componente collider2D do inimigo
            Destroy(col.gameObject.transform.parent.GetComponent<Collider2D>());
            // destroi o 2° filho do inimico, ou seja, o corpo.
            Destroy(col.gameObject.transform.parent.GetChild(1).gameObject);
            // destroi o script de movimento da slime
            Destroy(col.gameObject.transform.parent.gameObject.GetComponent<inimigo_mov>());
        }
        // o player morre se colidir com o corpo
        if (col.gameObject.CompareTag("Corpo_Tag"))
        {
            //respawn do jogador
            //transform.position = new Vector3(-0.159999996f, 2.71000004f, 0);
            transform.position = new Vector3(0f, 2.71000004f, 0);
        }


    }

}
