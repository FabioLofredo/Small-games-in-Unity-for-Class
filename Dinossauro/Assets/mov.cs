using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    // Start is called before the first frame update
      public bool esta_no_chao = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {  
            if (esta_no_chao == true)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0f, 6f, 0f);     
            }
        }
    }



    //se estiver em contato com o chão
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
            { 
                esta_no_chao = true;
            }        
    }
    //Se não estiver em contato com o chão
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Solo_Tag"))
        {
            esta_no_chao = false;
        }        
    }
}
