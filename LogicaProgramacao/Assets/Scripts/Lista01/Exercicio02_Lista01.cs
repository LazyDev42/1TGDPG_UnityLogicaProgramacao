using UnityEngine;

public class Exercicio02_Lista01 : MonoBehaviour
{
    /*
    2) Subtração de Vida
    Crie uma variável vida com valor 100.
    Crie uma variável dano com valor 25.
    Subtraia o dano da vida e mostre o resultado.
    Use o operador -.
    */

    int vida = 100;
    int dano = 25;

    void Start()
    {
        print("Sua vida atual é: " + vida);
        print("Você tomou um dano de: " + dano);
        print("Agora sua vida é: " + (vida - dano));
    }

   
}
