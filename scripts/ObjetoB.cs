using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoB : MonoBehaviour
{
    // Atributo privado que define un Vector3 para escalar el tamaño de los cubos.
    private Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);
    // Atributo que definirá al jugador (este objeto estará a su escucha).
    public Jugador jugador;
    // Atributo que definirá al objeto C (este objeto estará a su escucha).
    public ObjetoC objetoC;

    // Se llama al inicio de la ejecución.
    void Start()
    {
        jugador.AgrandarB += agrandarB;
        objetoC.OrientarObjetivo += orientarObjetivo;
    }

    // Se llama en cada momento.
    void Update()
    {}

    // Se emplea para agrandar el objeto B.
    void agrandarB()
    {
        transform.localScale += scale;
    }

    // Se emplea para orientar el objeto actual hacia el objetivo.
    void orientarObjetivo()
    {
        GameObject objetivo = GameObject.FindGameObjectWithTag("Objetivo");
        transform.LookAt(objetivo.gameObject.transform);
    }
}
