using UnityEngine;

public class Exercicio10_Lista05 : MonoBehaviour
{
    /*
    10. Sistema de Combate Simples
    Crie variáveis:
    • vidaJogador
    • vidaInimigo
    Verifique:
    • Se ambos > 0 ? "Combate em andamento" 
    • Se jogador <= 0 ? "Jogador derrotado" 
    • Se inimigo <= 0 ? "Inimigo derrotado"
    */

    [SerializeField] private int vidaJogador;
    [SerializeField] private int vidaInimigo;

    void Start()
    {
        if(vidaJogador > 0 && vidaInimigo > 0)
        {
            print("Combate em andamento.");
        }
        else if(vidaJogador <= 0)
        {
            print("Jogador derrotado.");
        }
        else if(vidaInimigo <= 0)
        {
            print("Inimigo derrotado.");
        }
    }

    
}
