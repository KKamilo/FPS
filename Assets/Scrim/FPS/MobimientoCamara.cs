using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobimientoCamara : MonoBehaviour
{
    float mauseX;
    float mauseY;
    public bool InvertedMouse;
    
    void Update()
    {
        //Aqui obtenemos la posicion del Mouse tanto en el eje Y como en el X y la vinculamos a la camara 
        Vector3 mousePosition = Input.mousePosition;
        mauseX += Input.GetAxis("Mouse X");
        if (InvertedMouse)
        {
            mauseY += Input.GetAxis("Mouse Y");
        }else
        {
            mauseY -= Input.GetAxis("Mouse Y");
        }
        // aqui se ajusta la camara de forma manual
        Debug.Log(mauseX);
        transform.eulerAngles = new Vector3(mauseY, mauseX, 0);
    }
}
