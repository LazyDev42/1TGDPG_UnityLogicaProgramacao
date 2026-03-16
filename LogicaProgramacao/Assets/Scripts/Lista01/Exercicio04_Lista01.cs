using UnityEngine;

public class Exercicio04_Lista01 : MonoBehaviour
{
    /*
     4) Divisão de Recursos
        O jogador tem 50 moedas e precisa dividir entre 5 personagens.
        Calcule quantas moedas cada um recebe.
        Use o operador /. 
     */

    int moedas = 50;
    int quantidadePersonagens = 5;
    void Start()
    {
        print("Temos " + moedas + " moedas. Divido entre nós 5, teremos " + (moedas / quantidadePersonagens) + " para cada um.");
    }
}
