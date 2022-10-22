using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public delegate void accion();
    public event accion AproximarC;
    public event accion AgrandarB;

    // Se llama al inicio de la ejecución.
    void Start()
    {}

    // Se llama en cada momento.
    void Update()
    {
        // Traslación.
        Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical"));
        transform.Translate(move * 10f * Time.deltaTime);

        // Rotación.
        transform.Rotate(0, Input.GetAxis("Horizontal") * 100f * Time.deltaTime, 0); 
    }

    // Se llama en caso de colisión.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ObjetoA")
        {
            AgrandarB();
        }

        if (collision.gameObject.tag == "ObjetoB")
        {
            AproximarC();
        }
    }
}
