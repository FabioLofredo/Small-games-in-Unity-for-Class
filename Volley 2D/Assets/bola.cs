using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // se acertar o chão
        if(col.gameObject.CompareTag("Solo_Tag"))
        {
            //volta a posição inicial
            gameObject.transform.position= new Vector3(5,3,0);
            // reseta a velocidade
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        }

    }
}
