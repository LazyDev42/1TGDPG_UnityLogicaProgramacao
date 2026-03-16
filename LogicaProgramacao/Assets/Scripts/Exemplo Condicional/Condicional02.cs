using UnityEngine;

public class Condicional02 : MonoBehaviour
{
    public int vida = 0;
    
    void Start()
    {
        if(vida > 0)
        {
            print("Personagem esta em jogo.");
        }
        else
        {
            print("Fim de jogo.");
        }
    }
    
}
