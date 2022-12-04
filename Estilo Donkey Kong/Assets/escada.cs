using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escada : MonoBehaviour
{   public GameObject player;
    public GameObject plataforma;
    public bool modo_escada = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // entra se estiver montado na escada
        if(modo_escada == true)
        {
        // sobe a escada
        if (Input.GetKey("w"))
        {
            player.transform.Translate(0, 1f* Time.deltaTime, 0);
        }
        // desce a escada
        if (Input.GetKey("s"))
        {
            player.transform.Translate(0, -1f* Time.deltaTime, 0);
        }
        // sai do modo escada se apertar "d" ou "a"
        if (Input.GetKey("d") ||Input.GetKey("a") )
        {
            modo_escada = false;
            plataforma.GetComponent<PlatformEffector2D>().enabled = false;
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            player.GetComponent<mov>().enabled=true;
        }

        }
    }

    //enquanto estiver na escada
    void OnTriggerStay2D(Collider2D other)
    {
        // monta na escada se apertar w ou s
        if(other.gameObject == player && modo_escada ==false)
        {
            if(Input.GetKey("w") || Input.GetKey("s"))
            {   
                modo_escada = true;
                plataforma.GetComponent<PlatformEffector2D>().enabled = true;
                player.GetComponent<Rigidbody2D>().gravityScale = 0;
                player.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
                player.GetComponent<mov>().enabled=false;
            }
        }

    }
    // desmonta da escada quando sair dela
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject == player )
        {
            modo_escada = false;
            plataforma.GetComponent<PlatformEffector2D>().enabled = false;
            player.GetComponent<Rigidbody2D>().gravityScale = 1;
            player.GetComponent<mov>().enabled=true;
        }
    }
}
