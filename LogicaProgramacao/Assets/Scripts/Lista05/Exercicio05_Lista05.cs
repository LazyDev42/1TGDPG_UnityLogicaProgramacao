using UnityEngine;

public class Exercicio05_Lista05 : MonoBehaviour
{
    /*
     5. Verificação de Velocidade
    Crie uma variável velocidade (float):
    • Se for maior que 10 ? "Muito rápido" 
    • Entre 5 e 10 ? "Velocidade média" 
    • Menor que 5 ? "Muito lento" 
     */

    [SerializeField] private float velocidade;

    void Start()
    {
        if(velocidade == 0)
        {
            print("Parado.");
        }
        else
        {
            if (velocidade > 10)
            {
                print("Muito rápido.");
            }
            else if (velocidade >= 5 && velocidade <= 10)
            {
                print("velocidade média");
            }
            else
            {
                print("Muito lento.");
            }
        }


        /*
        if (velocidade > 10)
        {
            print("Muito rápido.");
        }
        else if (velocidade >= 5 && velocidade <= 10)
        {
            print("velocidade média");
        }
        else
        {
            print("Muito lento.");
        }
        */
    }
    
}
