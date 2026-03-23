using UnityEngine;

public class Exercicio07_Lista05 : MonoBehaviour
{
    /*
     * 7. Nível do Jogador
        Com base na variável nivel:
        • <= 10 ? "Iniciante" 
        • <= 20 ? "Intermediário" 
        • > 20 ? "Avançado"
    */

    [SerializeField] private int nivel;

    void Start()
    {
        if (nivel <= 10)
        {
            print("Iniciante.");
        }
        else if (nivel <= 20)
        {
            print("Intermediario.");
        }
        else
        {
            print("Avançado.");
        }
    }

    
}
