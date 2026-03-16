using UnityEngine;

public class Condicional03 : MonoBehaviour
{
    /*
    1.	Crie um programa que:
    a.	Receba dois números
    b.	Mostre qual deles é maior.

    */

    public int numero1;
    public int numero2;


    void Start()
    {
        if(numero1 > numero2)
        {
            print(numero1 + " é maior que " + numero2);
        }
        else if(numero2 > numero1)
        {
            print(numero2 + " é maior que " + numero1);
        }
        else if(numero1 == numero2) 
        {
            print("São iguais.");
        }
    }  
}
