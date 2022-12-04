using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    public float Tempo_de_existencia = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //atualiza o tempo de existência
        Tempo_de_existencia += Time.deltaTime;

        //Se o tempo de existência for maior que 2
        if (Tempo_de_existencia > 2)
        {   //Irá destruir o próprio objeto, ou seja, a bala
            Destroy(gameObject);
        }
    }

    //Irá ser acionado quando colidir com outro colisor, quando o colisor estiver ativado o botão trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        // Irá verificar se o objeto que está colidindo possui a tag "bloco"
        if (other.gameObject.CompareTag("inimigo"))
            {
                //Irá destruir o objeto que está colidindo
                Destroy(other.gameObject);

                //Irá destruir o próprio objeto, ou seja, a bala
                Destroy(gameObject);
            }    
        if (other.gameObject.CompareTag("parede"))
            {

                //Irá destruir o próprio objeto, ou seja, a bala
                Destroy(gameObject);
            }    
        
    }
}
