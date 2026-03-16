using UnityEngine;

public class Exercicio10_Lista01 : MonoBehaviour
{
    /*
     10) Aumento Percentual
        Crie uma variável salario = 1000f.
        Aumente 10% no salário e mostre o valor final.
        Dica:
        salario + (salario * 0.10f
    */

    public float salario = 1000.0f;
    
    void Start()
    {    
        print(salario + (salario * 0.10f));
    }
   
}
