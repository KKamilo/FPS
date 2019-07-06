using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    float eje_X;
    public float speed = 0.1f;
    void Update()
    {
        /* Aqui establesemos en el personaje rporacion en el eje x para que
         * al momento de girar la camara tambien gira el personaje para 
         siguir hacia la pocicion del maus en el mismo eje x*/
        eje_X += Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, eje_X, 0);

        //Aqui asignamos el movimiento del personaje a las teclas WASD 
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed;
        }
    }
}
