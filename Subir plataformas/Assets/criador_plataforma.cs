using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criador_plataforma : MonoBehaviour
{   public GameObject plataforma;
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

        if (Tempo_de_existencia > 2)
        {
            //cria uma plataforma
            GameObject plataforma_temp = Instantiate(plataforma);
            //

            //nasce na mesma posição do player, em x gera uma posição aleatória entre -6 e 6
            plataforma_temp.transform.position = new Vector3(Random.Range(-6,7),gameObject.transform.position.y,gameObject.transform.position.z);
            //adiciona velocidade na plataforma
            plataforma_temp.GetComponent<Rigidbody2D>().velocity = new Vector3(0,-2,0);


            //reseta o tempo de existência
            Tempo_de_existencia = 0;
        }

    }
}
