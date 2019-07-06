using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapaDelJuego : MonoBehaviour
{
    
    GameObject esfera;
    GameObject[,] Matriz;
    public float distance = 0;
    void Start()
    {
        Matriz = new GameObject[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10 ; j++)
            {
                Matriz[i, j] = esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.GetComponent<Renderer>().material.color = Color.white;
                esfera.transform.position = new Vector3(j * distance, i * distance, 0f);


            }
        }
    }

    
    void Update()
    {
        
    }
}
