using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoA : MonoBehaviour
{
    // Definirá el color del objeto.
    private Color myColor;
    // Valores en RGBA del color del objeto.
    private float rFloat, gFloat, bFloat, aFloat;
    // Definirá la propiedad que permite mostrar al objeto en pantalla.
    private Renderer myRenderer;
    // Atributo privado que definirá los valores del movimiento en el eje X.
    private float xMovement;
    // Atributo privado que definirá los valores del movimiento en el eje Y.
    private float zMovement;
    // Atributo que define el componente RigidBody del objeto.
    Rigidbody myRigidBody;
    // Atributo que definirá al jugador (este objeto estará a su escucha).
    public Jugador jugador;
    // Atributo que definirá al objeto C (este objeto estará a su escucha).
    public ObjetoC objetoC;

    // Se llama al inicio de la ejecución.
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRenderer = GetComponent<Renderer>();

        jugador.AproximarC += acercarC;
        objetoC.ColorYSaltoA += color;
        objetoC.ColorYSaltoA += salto;
    }

    // Se llama en cada momento.
    void Update()
    {}

    // Se emplea para acercar el objeto actual al objeto C.
    void acercarC()
    {
        GameObject objectC = GameObject.FindGameObjectWithTag("ObjetoC");
        xMovement = objectC.GetComponent<Rigidbody>().position[0] - myRigidBody.position[0];
        zMovement = objectC.GetComponent<Rigidbody>().position[2] - myRigidBody.position[2];
        Vector3 direction = new Vector3(xMovement, 0f, zMovement);
        direction.Normalize();
        myRigidBody.AddForce(direction * 100f);
    }

    // Se emplea para cambiar el color del objeto actual.
    void color()
    {
        rFloat = Random.Range(0f, 1f);
        gFloat = Random.Range(0f, 1f);
        bFloat = Random.Range(0f, 1f);
        aFloat = Random.Range(0f, 1f);
        myColor = new Color(rFloat, gFloat, bFloat, aFloat);
        myRenderer.material.color = myColor;
    }

    // Se emplea para hacer saltar al objeto actual.
    void salto()
    {
        myRigidBody.AddForce(Vector3.up * 250f);
    }
}
