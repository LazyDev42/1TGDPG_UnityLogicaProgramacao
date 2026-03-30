using UnityEngine;

public class ExemploEntrada : MonoBehaviour
{

    [SerializeField] private int numero;

    int a;

    private void Start()
    {
        a = Random.Range(1, 100);
        print(a);
    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            print("Número digitado foi: " + numero);
        }
    }
}
