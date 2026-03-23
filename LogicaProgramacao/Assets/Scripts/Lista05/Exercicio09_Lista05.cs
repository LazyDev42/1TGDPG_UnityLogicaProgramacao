using UnityEngine;

public class Exercicio09_Lista05 : MonoBehaviour
{
    /*
     9. Acesso a Área Restrita
        Crie variáveis:
        • temChave (bool) 
        • nivel (int) 
        Permita acesso apenas se:
        • temChave == true e nivel >= 5 
     */

    [SerializeField] private bool temChanve;
    [SerializeField] private int nivel;

    void Start()
    {
        if(temChanve == true && nivel >= 5)
        {
            print("Entrou na área");
        }
        else
        {
            print("Área restrita.");
        }        
    }

}
