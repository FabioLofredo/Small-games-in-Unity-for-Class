using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class drag : MonoBehaviour
{
    //Referência para o colisor do objeto selecionado
    Collider2D targetObject;
    void Update()
    {
        //Posição do mouse no mundo
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Armazena o colisor do objeto selecionado quando se clica em cima dele
        if (Input.GetMouseButtonDown(0)) targetObject = Physics2D.OverlapPoint(mousePosition);
        
        //Limpa o armazenamento se soltar o botão do mouse
        if(Input.GetMouseButtonUp(0)) targetObject = null;

        //Move o objeto selecionado
        if (targetObject != null)targetObject.transform.position = new Vector2 (mousePosition.x,mousePosition.y);

    }
}
