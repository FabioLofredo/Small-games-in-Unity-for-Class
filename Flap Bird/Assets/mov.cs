using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //inicia pulando
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,280f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //zera a velocidade
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            // adiciona força no corpo
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,280f));


        }
    }
    void OnTriggerEnter2D(Collider2D col )
    {
        //se colidir com o chao ou o cano
        if(col.gameObject.CompareTag("solido"))
        { 
            // destroi ele mesmo
            Destroy(gameObject);
        }
    }
}
