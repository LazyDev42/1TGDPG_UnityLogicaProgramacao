using UnityEngine;

public class Condicional01 : MonoBehaviour
{
    [SerializeField] private string aluno;
    [SerializeField] private float nota1;
    [SerializeField] private float nota2;
    

    void Start()
    {
        float media = (nota1 + nota2)/2;

        print("Sua media é:" + media);

        if(media >= 6.0f)
        {
            print(aluno + " você foi aprovado.");
        }
        else
        {
            print(aluno + " você foi REPROVADO. AHAHAHA!");
        }

    }

    
}
