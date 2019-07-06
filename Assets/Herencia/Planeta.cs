using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{

    void Start()
    {
        Fauna animal = new Fauna();
        Flora vegetacion = new Flora();
        Ecosistema sitio = new Ecosistema();    
        animal.Animales();
        vegetacion.Plantas();
        sitio.Lugar();
    }
    public class Naturaleza 
    {
        public void Entorno ()
        {
            Debug.Log("Bosque");
        }
    }
    public class Fauna : Naturaleza
    {
        public void Animales()
        {
            Entorno();
            Debug.Log("Ardillas, Pajaros, Simios, Gusanos, Hormigas, Panteras");

        }
    }
    public class Flora : Naturaleza
    {
        public void Plantas()
        {
            Entorno();
            Debug.Log("Arboles, flores");

        }
    }
    public class Ecosistema : Naturaleza
    {
        public void Lugar()
        {
            Entorno();
            Debug.Log("Amasonas");

        }
    }
}
