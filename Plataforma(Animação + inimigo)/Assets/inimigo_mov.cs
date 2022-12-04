using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo_mov : MonoBehaviour
{
    public Vector3 inicio = new Vector3(0, 0);
    public Vector3 fim = new Vector3(0, 0);
    public bool sentido_inicio_fim = true;
    private float caminho = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = inicio;
    }

    // Update is called once per frame
    void Update()
    {   // indo do inicio para o final
        if (sentido_inicio_fim == true)
        {
            caminho = caminho + 0.002f;
            //se chegou no final
            if (caminho >= 1) sentido_inicio_fim = false;
        }
        //voltando
        if (sentido_inicio_fim == false)
        {
            caminho = caminho - 0.002f;

            // se chegou no inicio
            if (caminho <= 0) sentido_inicio_fim = true;
        }
        // Vector2.Lerp retorna um lugar entre o inicio e o fim do percurso
        // baseado no valor do caminho que varia de 0 a 1
        transform.position = Vector2.Lerp(inicio, fim, caminho);
        

    }
}
