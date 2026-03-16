using UnityEngine;

public class Exercicio12_Lista01 : MonoBehaviour
{
    /*
    12) Sistema de Pontuação Completo
        Crie:
        • public int pontosBase;
        • public int inimigosDerrotados;
        • public int bonus;
        Calcule:
        pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
        Mostre o resultado no Console.
    */

    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;

    void Start()
    {
        int pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
        print(pontuacaoFinal);
    }
      
}
