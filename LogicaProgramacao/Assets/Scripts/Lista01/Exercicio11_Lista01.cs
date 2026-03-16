using UnityEngine;

public class Exercicio11_Lista01 : MonoBehaviour
{
    /*
    Velocidade com Aceleração
    Crie:
    • public float velocidadeInicial;
    • public float aceleracao;
    • public float tempo;
    Calcule a velocidade final usando:
    velocidadeFinal = velocidadeInicial + aceleracao * tempo
    */

    public float velocidadeInicial;
    public float aceleracao;
    public float tempo;

    void Start()
    {
        float velocidadeFinal = velocidadeInicial + aceleracao * tempo;
        print("Velocidade final: " + velocidadeFinal);
    }
       
}
