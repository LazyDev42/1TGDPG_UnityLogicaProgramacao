// Importa a biblioteca principal da Unity
using UnityEngine; 

// Declaração da classe que herda de MonoBehaviour (base para scripts na Unity)
public class CondicionalComposto02 : MonoBehaviour
{
    // Variável privada do tipo inteiro, visível no Inspector da Unity
    // Começa com valor inicial de 100
    [SerializeField] private int moeda = 100;

    // Método Start é chamado automaticamente pela Unity quando o jogo começa
    void Start()
    {
        // Verifica se o valor de moeda está entre 0 e 10 (inclusive)
        if (moeda >= 0 && moeda <= 10)
        {
            // Multiplica o valor por 1 (ou seja, não altera o valor)
            moeda = moeda * 1;
        }
        // Verifica se o valor está entre 11 e 50
        else if (moeda > 10 && moeda <= 50)
        {
            // Multiplica o valor por 5
            moeda = moeda * 5;
        }
        // Verifica se o valor está entre 51 e 100
        else if (moeda > 50 && moeda <= 100)
        {
            // Multiplica o valor por 5 (mesma regra do bloco anterior)
            moeda = moeda * 5;
        }
        else
        {
            // Caso o valor seja maior que 100 ou menor que 0 (fora das condições anteriores)
            // Multiplica o valor por 15
            moeda = moeda * 15;
        }

        // Exibe no console da Unity o valor final da moeda após aplicar o bônus
        print("Valor com bonus: " + moeda);
    }
}