using UnityEngine;

public class Exercicio01_Lista01 : MonoBehaviour
{
    /*
    1) Soma Simples
    Crie duas variáveis inteiras (int) chamadas a e b.
    Atribua valores e mostre no Console o resultado da soma.
    Use o operador + e Debug.Log() ou Print().
    */

    int a = 100;
    int b = 50;

    void Start()
    {
        int resultado = a + b;
        print("Soma de a + b:" + resultado);
    }
        
}
