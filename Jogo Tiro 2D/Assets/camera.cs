using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{   // Cria a referencia de um jogador (precisa linkar o objeto jogador no script no unity)
    public GameObject jogador;

    void Start()
    {

    }

    void Update()
    {
        //move a câmera junto com o jogador
        transform.position = new Vector3( jogador.transform.position.x, jogador.transform.position.y, -10);
    }
}