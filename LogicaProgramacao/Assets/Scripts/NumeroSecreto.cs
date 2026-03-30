using UnityEngine;

public class NumeroSecreto : MonoBehaviour
{
    // JOGADRO INFORMA O NÚMERO PARA TENTAR DESCOBRIR O NÚMERO DA CPU
    [SerializeField] private int numeroJogador;

    [Header("Dificuldade fácil 1 até 50")]
    [SerializeField] private bool facil;

    [Header("Dificuldade média 1 até 100")]
    [SerializeField] private bool media;

    [Header("Dificuldade dificil 1 até 500")]
    [SerializeField] private bool dificil;


    // VARIAVEL CRIADA PARA GUARDAR O NUMERO DA CPU
    private int numeroCPU;

    private int tentativas = 0;

    void Start()
    {
        if (facil == false && media == false && dificil == false)
        {
            print("Escolha somente 1 grau de dificuldade.");
        }
        else if(facil == true && media == true && dificil == true)
        {
            facil = true;
            media = false;
            dificil = false;
        }
        else
        {
            // VALIDA A DIFICULDADE E GERA O VALOR DA CPU
            if (facil == true)
            {
                numeroCPU = Random.Range(1, 51);
            }
            else if (media == true)
            {
                numeroCPU = Random.Range(1, 101);
            }
            else if (dificil == true)
            {
                numeroCPU = Random.Range(1, 501);
            }
        }
        // HABILITA O JOGO FORNCENDO TENTATIVAS PARA O JOGADOR
        tentativas = 3;

    }
    
    void Update()
    {
        // LOOPING DO JOGO
        if (Input.anyKeyDown && tentativas > 0)
        {
            // REGISTRA UMA TENTATIVA
            print("Tentativa: " + tentativas);
            tentativas--;

            // DAR DICA SOBRE O INTERVALO NA ÚLTIMA TENTATIVA
            if(tentativas == 1)
            {
                // GERA A VALOR MINIMO PARA DICA DO INTERVALO
                // E TRATA OS VALORES PARA FICAREM DENTRO DO INTERVALO
                int min = numeroJogador - 10;                               
                if(min < 0)
                {
                    min = 0;
                }

                int max = numeroJogador + 10;                   
                if(max > 100)
                {
                    max = 100;  
                }

                // EXIBE A DICA
                print("O número da cpu esta entre: " + min + " e " + max);
            }

            // CONDICAO DE VITORIA
            if (numeroJogador == numeroCPU)
            {                
                print("Você acertou.");
            }
            else
            {
                // VERIFICA O VALOR PARA DAR DICA AO JOGADOR
                if(numeroJogador < numeroCPU)
                {
                    // SE O JOGADOR INFORMOU UM NUMERO BAIXO EM RELACAO DA CPU DEVE JOGAR MAIS ALTO
                    print("Número do jogador esta muito baixo.");
                }
                else
                {
                    // SE O JOGADOR INFORMOU UM NUMERO MAIS ALTO EM RELACAO DA CPU DEVE JOGAR MAIS BAIXO
                    print("Número do jogador esta muito alto.");
                }
            }
        }
        else if(tentativas == 0)
        {
            tentativas = -1;
            print("Game over, você esgotou as tentativas.");
        }
    }
}
