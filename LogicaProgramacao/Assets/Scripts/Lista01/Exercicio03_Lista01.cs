using UnityEngine;

public class Exercicio03_Lista01 : MonoBehaviour
{
    /*
    3) Multiplicação de Pontos
    Crie uma variável pontos com valor 10.
    Crie uma variável multiplicador com valor 3.
    Calcule a pontuação final e mostre no Console.
    Use o operador *.
    */

    int pontos = 10;
    int multiplicador = 3;

    void Start()
    {
        print("Pontuação atual: " + pontos);
        print("Multiplicado por 3 será: " + (pontos * multiplicador));
    }

  
}
