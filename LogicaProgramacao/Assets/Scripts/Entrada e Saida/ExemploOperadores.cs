using UnityEngine;

public class ExemploOperadores : MonoBehaviour
{
    /*
     * CRIE UM PROGRAMA QUE RECEBE O NOME DE UM ALUNO, DUAS NOTAS.
     * EXIBA SUA MÉDIA E MOSTRE SE ELE FOI APROVADO.       
     */

    [SerializeField] private string aluno;
    [SerializeField] private float nota1;
    [SerializeField] private float nota2;


    void Start()
    {
        float media = (nota1 + nota2) / 2;
        print(aluno + " sua média foi : " + media);

        bool aprovado = media >= 6.0f;
        print(aluno + " foi aprovado(a)?" + aprovado);

        Debug.Log("Fiap");
    }    
}
