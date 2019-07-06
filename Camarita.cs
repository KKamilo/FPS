using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camarita : MonoBehaviour
{
    public float mouseX ;
    public float mouseY ;
    public bool invertedAxis;
    public float speed;

    void Update()
    {    
        //Aqui obtenemos la posicion del Mouse tanto en el eje Y como en el X y la vinculamos a la camara 
        mouseX += Input.GetAxis("Mouse X");
        if (invertedAxis)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }

        // aqui se ajusta la velocidad de la camara de forma manual
        Debug.Log(mouseX);
        transform.eulerAngles = new Vector3(mouseY*speed, mouseX*speed, 0);
    }
}
