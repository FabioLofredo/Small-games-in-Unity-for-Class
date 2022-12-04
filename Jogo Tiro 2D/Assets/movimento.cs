using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x,gameObject.transform.localEulerAngles.y,gameObject.transform.localEulerAngles.z+0.5f );

        if(Input.GetKey("d"))
        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x,gameObject.transform.localEulerAngles.y,gameObject.transform.localEulerAngles.z-0.5f );

        //Space.Self pega a referência do movimento no próprio eixo, e não do mundo
        if(Input.GetKey("w"))
        gameObject.transform.Translate(new Vector3(0.01f,0,0), Space.Self);

        if(Input.GetKey("s"))
         gameObject.transform.Translate(new Vector3(-0.004f,0,0), Space.Self);

    }
}
