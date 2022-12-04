using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour
{
    private float tempo_de_existencia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // atualiza o tempo de existencia
        tempo_de_existencia += Time.deltaTime;

        //destroi se passar um tempo
        if(tempo_de_existencia > 8)
            {
                Destroy(gameObject);
            }
    }
}
