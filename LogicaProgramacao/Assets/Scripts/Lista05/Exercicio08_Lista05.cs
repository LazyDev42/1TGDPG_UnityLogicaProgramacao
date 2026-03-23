using UnityEngine;

public class Exercicio08_Lista05 : MonoBehaviour
{
    /*
    8. Sistema de Clima no Jogo
    Crie uma variável temperatura:
    • > 30 ? "Clima quente" 
    • >= 15 ? "Clima agradável" 
    • < 15 ? "Clima frio"
    */

    [SerializeField] private int clima;

    void Start()
    {
        if (clima > 30)
        {
            print("Quente.");
        }
        else if (clima >= 15)
        {
            print("Agradavel.");
        }
        else
        {
            print("Frio.");
        }
        
    }

    
}
