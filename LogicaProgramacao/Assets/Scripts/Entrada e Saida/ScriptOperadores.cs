using UnityEngine;

public class ScriptOperadores : MonoBehaviour
{
    [SerializeField] private int a;
    [SerializeField] private int b;
   
    void Start()
    {
        int c = 0;

        print("Exemplo de operadores matematicos");

        // OPERADOR DE SOMAR (+)
        c = a + b;
        print("Soma de a + b: " + c);

        // OPERADOR DE SUBTRAÇÃO (-)
        c = a - b;
        print("Subtração de a - b: " + c);

        // OPERADOR DE DIVISÃO
        c = (a + b) / 2;
        print("Divisão de (a+b)/2: " + c);

        c = (a + b) % 2;
        print("Sobrou: " + c);

        print("Exemplo de operadores relacionais");
        int x = 200;
        int y = 50;
        print("x = " + x);
        print("y = " + y); 

        print("x == y: " + (x == y));
        print("x != y: " + (x != y));
        print("x >  y: " + (x > y));
        print("x >= y: " + (x >= y));
        print("x >= y: " + (x <= y));
    }   


    
}
