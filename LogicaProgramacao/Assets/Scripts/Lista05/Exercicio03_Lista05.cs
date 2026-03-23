using UnityEngine;

public class Exercicio03_Lista05 : MonoBehaviour
{
    /*
      3. Sistema de Vida do Jogador
          Crie uma variável vida (int).
        • Se vida > 0, mostre "Jogador vivo" 
        • Caso contrário, mostre "Game Over
     */

    [SerializeField] private int vida;

    void Start()
    {
        if (vida > 0)
        {
            print("Jogador vivo.");
        }
        else
        {
            print("Game over.");
        }
    }

   
}
