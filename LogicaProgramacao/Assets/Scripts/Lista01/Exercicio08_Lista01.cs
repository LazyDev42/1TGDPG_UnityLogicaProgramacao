using UnityEngine;

public class Exercicio08_Lista01 : MonoBehaviour
{
    /*
   8) Sistema de Dano Dinâmico
        Crie:
        • public int vida = 100;
        • public int dano;
        No Start(), diminua a vida pelo dano informado no Inspector e mostre o 
        resultado
    */

    public int vida = 100;
    int dano;

    void Start()
    {
        print("Sua vida atual é: " + vida);

        dano = Random.Range(1, 21);

        print("Você tomou dano de: " + dano);

        print("Agora sua vida é: " + (vida - dano));
    }

   
}
