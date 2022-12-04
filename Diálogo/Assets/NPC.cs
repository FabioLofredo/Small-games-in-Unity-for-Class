using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{   [SerializeField]
    private bool player_perto = false;
    [SerializeField]
    private Text dialogo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //se o player estiver perto, aperte uma tecla para mudar o texto
        if(player_perto == true)
        {
            if(Input.GetKeyDown("space"))
            {
                dialogo.text = "Apertou espaço no NPC!";
            }
            if(Input.GetKeyDown("1"))
            {
                dialogo.text = "Apertou 1!";
            }
            if(Input.GetKeyDown("2"))
            {
                dialogo.text = "Apertou 2!";
            }
            if(Input.GetKeyDown("3"))
            {
                dialogo.text = "Apertou 3!";
            }
        }

        if(Input.GetKeyDown("escape"))
        {
            //se apertar esc reseta o texto
            dialogo.text = "";

        }
    }





    //se o player colidir muda o player_perto para verdadeiro
    private void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.CompareTag("Player"))
        {
            player_perto = true;
        }
    }
    // se o player sair muda o player_perto para longe
    private void OnTriggerExit2D(Collider2D col) {
         if(col.gameObject.CompareTag("Player"))
        {
            player_perto = false;
        }
    }
}
