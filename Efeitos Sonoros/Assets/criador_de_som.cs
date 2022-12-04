using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criador_de_som : MonoBehaviour
{
    public GameObject efeito_sonoro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Caso colidir com um objeto
    void OnTriggerEnter2D(Collider2D col)
    {
        //Caso o objeto tenha a tag de comida
        if (col.gameObject.CompareTag("comida"))
        {
            //Destroi o objeto em contato
            Destroy(col.gameObject);
            //Cria um objeto que irá criar som
            Instantiate(efeito_sonoro);
        }

    }
  
    // Caso queira usar Collision com o Trigger desativado
    /*
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("comida"))
        {
            Destroy(col.gameObject);
            Instantiate(efeito_sonoro);
        }


    }
    */
}
