using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    //Variables
    //El TIpo de Dato      Nombre
    int numeroDeSaltos = 0;

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision infoChoque)
    {
        numeroDeSaltos = numeroDeSaltos + 1;
        /*Debug.Log("Veces que he colisionado: " + miVariable + " " + gameObject.name);
        
        Debug.Log("Veces que he chocado: " + infoChoque.gameObject.name);
        */

        if (numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name + " He chocado " + numeroDeSaltos + " veces");
        }
       
    }
}
