using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    // Start is called before the first frame update
    //Crea un programa que pida dos números al usuario y responda si son iguales o no lo son.
    public int num1, num2;

    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los numeros son iguales");
        }
        else
        {
            Debug.Log("Los numeros no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
