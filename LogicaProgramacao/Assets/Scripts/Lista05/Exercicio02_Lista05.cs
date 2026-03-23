using UnityEngine;

public class Exercicio02_Lista05 : MonoBehaviour
{
    /*
     2. Comparação de Três Números
        Declare três variáveis float e mostre qual delas é a maior
    */

    [SerializeField] private float a, b, c;

    void Start()
    {
        if (a > b && a > c)
        {
            print(a);
        }
        else if (b > a && b > c)
        {
            print(b);
        }
        else
        {
            print(c);
        }
    }   
}
