using UnityEngine;

public class Exercicio09_Lista01 : MonoBehaviour
{
    /*
    9) Dobro e Metade
    Crie uma variável numero.
    Mostre:
    • O dobro do número.
    • A metade do número.    
     */

    public float numero;

    void Start()
    {
        print("Dobro de " + numero + " é:" + (numero * 2));
        print("Metade de " + numero + " é:" + (numero / 2));
    }

   
}
