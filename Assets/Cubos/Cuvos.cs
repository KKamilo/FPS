using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuvos : MonoBehaviour
{
    public bool checck; // Variable logica
    
    GameObject colorTemporal; // Es un objeto temporal para almacenar el color
    GameObject esfera; // Es un objeto que crea las esferas
    GameObject colorAnterior;// Es un objeto temporal para almacenar el color

    PrenderYApagar prenderYApagar = new PrenderYApagar(); // Clase que prende, apaga y verifica
    public void Crear() // Clase que crea las filas y columnas
    {

        int Fil = Random.Range(3, 13); //Variable que da numero aleatorio para las filas entre 3 y 12
        int Col = Random.Range(3, 13); //Variable que da numero aleatorio para las columnas entre 3 y 12

        for (int i = 0; i < Fil; i++) //For (Para) que controlas las cantidad de linias en filas que crea
        {
            for (int j = 0; j < Col; j++) //For (Para) que controlas las cantidad de linias en columnas que crea
            {
                esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere); // Crea la esfera
                esfera.transform.position = new Vector3(j * 2.0f, i * 2.0f, 0f); // Coloca la esfera en la pocicion que le corresponde 

                int iro = Random.Range(0, 6); // Variable que da un numero aleatorio del 0 al 5
                switch (iro) // Swith que verifica el numero dado anterior.
                {
                    case 0: // Primera opcion
                        esfera.GetComponent<Renderer>().material.color = Color.white; // Pinta el objeto del color Blanco
                        break;
                    case 1: // Segunda opcion
                        esfera.GetComponent<Renderer>().material.color = Color.red; // Pinta el objeto del color Rojo
                        break;
                    case 2: // Tercera opcion
                        esfera.GetComponent<Renderer>().material.color = Color.blue; // Pinta el objeto del color Azul
                        break;
                    case 3: // Cuarta opcion
                        esfera.GetComponent<Renderer>().material.color = Color.green; // Pinta el objeto del color Verde
                        break;
                    case 4: // Quinta opcion
                        esfera.GetComponent<Renderer>().material.color = Color.magenta; // Pinta el objeto del color Magenta
                        break;
                    case 5: // Cesta opcion
                        esfera.GetComponent<Renderer>().material.color = Color.yellow; // Pinta el objeto del color Amarillo
                        break;
                }
                colorAnterior = colorTemporal; // El Objeto temporal colorAnterior que da nulo en la primera interacion 
                colorTemporal = esfera;// El Objeto esfera le da al Objeto temporal Antercolor los valores de la esfera que almacena el

                if (j > 0) // Verifica que la variable j cumpla la condicion para permitirle al progama entrar a su linia de codigo
                {
                    if (prenderYApagar.Verificar(colorAnterior.GetComponent<Renderer>().material.color, esfera.GetComponent<Renderer>().material.color)) // Va a la clase PrenderYApagar y al metodo Verificar para comparar el color
                    {
                        colorAnterior.GetComponent<Renderer>().material.color = Color.black; // Pinta el objeto del color Negro
                        esfera.GetComponent<Renderer>().material.color = Color.black; // Pinta el objeto del color Negro
                    }
                }
            }
        }
    }

    void Update()
    {

        if (checck == true) // verifica que el checck se alla undido
        {
            Debug.Log("Encendido"); //Imprime en consola
            Crear(); // Entra a la clase Crear

            checck = false; // Pone el checck en falso
            Debug.Log("Apagado"); //Imprime en consola
        }

    }

   
}