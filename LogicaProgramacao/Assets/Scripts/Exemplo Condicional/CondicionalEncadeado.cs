using UnityEngine;

public class CondicionalEncadeado : MonoBehaviour
{

    private int dadoJogador1;
    private int placarJogador1;

    private int dadoJogador2;
    private int placarJogador2;     

    void Update()
    {
        // VERIFICA SE UMA TECLA FOI PESSIONADO PARA EXECUTAR A RODADA
        if (Input.anyKeyDown)
        {
            // VALIDA A PARTIDA
            if(placarJogador1 < 3 || placarJogador2 < 3)
            {
                // GERA OS NÚMEROS DOS DADOS DO JOGADOR ALEATORIAMENTE
                dadoJogador1 = Random.Range(1, 7);
                dadoJogador2 = Random.Range(1, 7);

                print("Dado jogador 1: " + dadoJogador1);
                print("Dado jogador 2: " + dadoJogador2);

                // VERFICA OS RESULTADO DA RODADA
                if (dadoJogador1 == dadoJogador2)
                {
                    print("Empate.");
                }
                else
                {
                    if (dadoJogador1 > dadoJogador2)
                    {
                        placarJogador1 += 1;
                        print("Jogador 1 venceu a rodada.");
                    }
                    else if (dadoJogador2 > dadoJogador1)
                    {
                        placarJogador2 += 1;
                        print("Jogador 2 venceu a rodada.");
                    }

                    print("Jogador 1: " + placarJogador1);
                    print("Jogador 2: " + placarJogador2);
                    print("----------------------------");
                }
            }
            else
            {
                // TERMINA A PARTIDA E VERIFCA QUEM GANHOU
                if(placarJogador1 > placarJogador2)
                {
                    print("Jogador 1 venceu.");
                }
                else
                {
                    print("Jogador 2 venceu.");
                }
            }


            

           

        }        
    }
}
