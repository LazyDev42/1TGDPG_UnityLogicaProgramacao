using UnityEngine;

public class CondicionalComposto01 : MonoBehaviour
{

    [SerializeField] private string classePersonagem;

    void Start()
    {
        if (classePersonagem == "")
        {
            print("Erro. Informe a classe.");
        }
        else if (classePersonagem == "1")
        {
            print("Você escolheu o mago.");
        }
        else if (classePersonagem == "2")
        {
            print("Você escolheu o arqueiro");
        }
        else if (classePersonagem == "3")
        {
            print("Você escolheu o barbaro");
        }
        else
        {
            print("Erro. Classe não existe.");
        }
    }    
}
