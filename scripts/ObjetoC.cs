using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoC : MonoBehaviour
{
    public delegate void accion();
    public event accion ColorYSaltoA;
    public event accion OrientarObjetivo;

    // Se llama al inicio de la ejecución.
    void Start()
    {}

    // Se llama en cada momento.
    void Update()
    {}

    // Se llama cada vez que se entra en el trigger del objeto.
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            ColorYSaltoA();
            OrientarObjetivo();
        }
    }
}
