using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    // Start is called before the first frame update
    //Solicitar el ingreso del precio de 3 productos y un monto de dinero disponible.
    //Comunicar si la suma de los mismos supera o no el monto de dinero disponible.
    //Luego indicar cuánto dinero sobra o falta.
    public float precio1, precio2, precio3, disponible;
    float sobra, falta;
    void Start()
    {
        sobra = disponible - (precio1 + precio2 + precio3);
        if (sobra >= 0)
        {
            Debug.Log("El precio total no es mayor que el dinero disponible, sobran " + sobra + " pesos.");
        }
        else
        {
            falta = (precio3 + precio2 + precio1) - disponible;
            Debug.Log("El precio total es mayor que el dinero disponible, faltan " + falta + " pesos.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
