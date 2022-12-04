using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play_music : MonoBehaviour
{
    public AudioSource musica;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        //Caso colidir com um objeto
    void OnTriggerEnter2D(Collider2D col)
    {
        //Caso o objeto tenha a tag de Player
        if (col.gameObject.CompareTag("Player"))
        {

            //Toca a música
            musica.Play();
        }

    }
}
