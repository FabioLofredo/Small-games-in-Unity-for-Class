using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arvores : MonoBehaviour
{   int numero_de_arvores= 0; 
    public GameObject arvore;
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

        if (Tempo_de_existencia > 3)
        {   
            // só vai entrar aqui se numero de arvores for 0
            if (numero_de_arvores == 0)
            {   
                // gera um número aleatório de 1 a 3 arvores
                numero_de_arvores = Random.Range(1, 4);
            }
            
            //cria uma arvore
            GameObject arvore_temp = Instantiate(arvore);
            //nasce na mesma posição do player
            arvore_temp.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
            //adiciona velocidade na arvore
            arvore_temp.GetComponent<Rigidbody2D>().velocity = new Vector3(-5,0,0);

            //subtrai o número de arvores em 1
            numero_de_arvores = numero_de_arvores - 1;
           // subtrai o tempo de existência em 0.2 segundos
           Tempo_de_existencia = Tempo_de_existencia -0.2f;

            // Se o número de arvores chegou a 0, ele zera o tempo de existência para iniciar outra série
            // se não chegou a zero, ou seja, número de arvores é 1 ou 2, então vai esperar os 0.2 segundos e rodar novamente
           if (numero_de_arvores == 0)
           {
                //reseta o tempo de existência
                Tempo_de_existencia = 0;
           } 

        }
    }
}
