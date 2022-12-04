using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criar_bola : MonoBehaviour
{
    public GameObject bola; 
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

    if (Tempo_de_existencia > 5)
        {   
            //cria a bola
            GameObject bola_temp = Instantiate(bola);
            //nasce na mesma posição do player
            bola_temp.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
            //reseta o tempo de existencia
            Tempo_de_existencia = 0;
        }
        
    }
}
