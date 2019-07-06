using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Camarita rt;
    public float speed =0.1f;
    void Update()
    {   
        //Aqui asignamos el movimiento del personaje a las teclas WASD 
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward*speed;
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
        //Aqui se asigna la rotacion del eje Y del personaje segun el eje X de la camara  
        transform.eulerAngles = new Vector3(0, rt.mouseX * rt.speed, 0);

    }
}
