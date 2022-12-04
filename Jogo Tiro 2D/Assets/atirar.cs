using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atirar : MonoBehaviour
{
    public GameObject bala;
    private int velocidade = 20;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {   //atirar com teclado
        if (Input.GetKeyDown("space"))
        { 
            //cria a bala
            GameObject bala_temp = Instantiate(bala);

            //nasce na mesma posição do player
            bala_temp.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
            
            // rotaciona a bala na mesma rotação do player
            bala_temp.transform.localEulerAngles = new Vector3(0,0,gameObject.transform.localEulerAngles.z );

            // da velocidade na bala na direção do player
            bala_temp.GetComponent<Rigidbody2D>().velocity = new Vector3 (velocidade* Mathf.Cos(  gameObject.transform.localEulerAngles.z * Mathf.Deg2Rad), velocidade* Mathf.Sin( gameObject.transform.localEulerAngles.z* Mathf.Deg2Rad));
            // Mathf.Cos gera o cosseno e Mathf.Sin gera o seno
            // * Mathf.Deg2Rad transforma graus em radiano
           
        }
        //atirar com mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        { 
            //cria a bala
            GameObject bala_temp = Instantiate(bala);

            //nasce na mesma posição do player
            bala_temp.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
            
            // rotaciona a bala na mesma direção do mouse em relação ao centro da tela
            // Vector.Angle da o angulo entre dois vetores
            // Screen.width é o comprimento total da tela, e Screen.height é a altura total
            // Input.mousePosition.x é a posição x do mouse com referência no canto esquedo inferior da tela, Input.mousePosition.y é a posição do mouse em y
            bala_temp.transform.localEulerAngles = new Vector3(0,0,Vector2.Angle(new Vector2 (1,0),new Vector2(Input.mousePosition.x-Screen.width/2,Input.mousePosition.y-Screen.height/2)));
            if(Input.mousePosition.y-Screen.height/2 < 0) // Se o angulo for maior de 180 graus
            bala_temp.transform.localEulerAngles = new Vector3(0,0,360-Vector2.Angle(new Vector2 (1,0),new Vector2(Input.mousePosition.x-Screen.width/2,Input.mousePosition.y-Screen.height/2)));
     

            // da velocidade na bala na direção do mouse em relação ao centro da tela
            Vector2 direction = new Vector2(Input.mousePosition.x-Screen.width/2,Input.mousePosition.y-Screen.height/2);
            direction.Normalize();
            bala_temp.GetComponent<Rigidbody2D>().velocity = new Vector3 (velocidade* direction.x , velocidade*  direction.y);
            // direction é o vetor direção
            // direction.Normalize(); normaliza o vetor, tem tamanho 1

        }


    }
}
