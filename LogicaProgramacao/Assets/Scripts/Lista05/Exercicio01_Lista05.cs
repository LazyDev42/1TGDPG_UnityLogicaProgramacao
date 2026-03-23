using UnityEngine;

public class Exercicio01_Lista05 : MonoBehaviour
{
    /*
    1. Verificação de Número Positivo, Negativo ou Zero
    Crie um script que receba um número inteiro e informe:
    • Se é maior que 0 ? "Número positivo" 
    • Se é menor que 0 ? "Número negativo" 
    • Caso contrário ? "Zero"
    */

    [SerializeField] private int numero;

    void Start()
    {
        /*
        if(numero == 0)
        {
            print(numero + " é zero.");
        }
        else
        {
            if(numero > 0)
            {
                print(numero + " positivo.");
            }
            else
            {
                print(numero + " negativo.");
            }
        }
        */

       
        if (numero == 0)
        {
            print(numero + " é zero.");
        }
        else if (numero > 0)
        {
            print(numero + " é positivo.");
        }
        else if (numero < 0)
        {
            print(numero + " é negativo.");
        }
       
    }
   
}
