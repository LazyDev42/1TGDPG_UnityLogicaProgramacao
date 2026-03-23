using UnityEngine;

public class Exercicio06_Lista05 : MonoBehaviour
{

    /*
    6. Sistema de Compra no Jogo
    Crie variáveis:
    • moedas (int) 
    • custoItem (int) 
    Verifique:
    • Se moedas >= custoItem ? "Compra realizada" 
    • Senão ? "Moedas insuficientes"
    */

    [SerializeField] private int moedas;
    [SerializeField] private int custoItem;

    void Start()
    {
        if(moedas > 0)
        {
            if (moedas >= custoItem)
            {
                print("Compra foi realizada.");
            }
            else
            {
                print("Moedas insuficiente.");
            }
        }
        else
        {
            print("Sem moedas.");
        }

        
    }

   
}
