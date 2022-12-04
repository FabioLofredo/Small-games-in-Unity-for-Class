using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float velocidade = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))gameObject.transform.Translate(0,velocidade,0);
        if(Input.GetKey(KeyCode.DownArrow))gameObject.transform.Translate(0,-velocidade,0);
        if(Input.GetKey(KeyCode.LeftArrow))gameObject.transform.Translate(-velocidade,0,0);
        if(Input.GetKey(KeyCode.RightArrow))gameObject.transform.Translate(velocidade,0,0);
    }
}
