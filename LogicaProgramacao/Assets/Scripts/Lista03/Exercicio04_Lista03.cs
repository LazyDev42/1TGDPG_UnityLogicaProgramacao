using UnityEngine;

public class Exercicio04_Lista03 : MonoBehaviour
{
    /*
     * 4.	Peça dois números e:
        a.	Verifique se eles são iguais ou diferentes.
    */

    public int numero1;
    public int numero2;

    void Start()
    {
        if(numero1 != numero2)
        {
            print("Números são diferentes.");            
        }
        else
        {
            print("Números são iguais.");
        }        
    }  
}
