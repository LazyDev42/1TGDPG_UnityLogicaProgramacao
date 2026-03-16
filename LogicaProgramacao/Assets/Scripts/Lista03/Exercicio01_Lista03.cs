using Unity.Android.Gradle;
using UnityEngine;

public class Exercicio01_Lista03 : MonoBehaviour
{
    /*
     1. Crie um programa que:
        a. Receba dois números
        b. Mostre qual deles é maior. 
     */

    public int numero1;
    public int numero2;

    void Start()
    {
        if(numero1 > numero2)
        {
            print(numero1);
        }
        else
        {
            print(numero2);
        }
    }

  
}
