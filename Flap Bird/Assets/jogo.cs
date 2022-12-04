using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jogo : MonoBehaviour
{
    public GameObject cano;
    private float tempo_ciclo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // atualiza o tempo do ciclo
        tempo_ciclo += Time.deltaTime;

        if(tempo_ciclo > 2.5)
        {
            // cria 2 canos
            GameObject cano_cima_temp = Instantiate(cano);
            GameObject cano_baixo_temp = Instantiate(cano);

            // gera um numero aleatório para altura do cano
            int altura = Random.Range(-9,-3);

            // posiciona os canos
            cano_cima_temp.transform.position = new Vector3(13,altura+13,1);
            cano_baixo_temp.transform.position = new Vector3(13,altura,1);

            // adiciona velocidade nos canos
            cano_cima_temp.GetComponent<Rigidbody2D>().velocity = new Vector2(-3,0);
            cano_baixo_temp.GetComponent<Rigidbody2D>().velocity = new Vector2(-3,0);

            //reseta o tempo de ciclo
            tempo_ciclo =0;

        }
    }
}
