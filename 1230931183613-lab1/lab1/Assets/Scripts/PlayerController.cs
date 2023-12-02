using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This player controller class will update the events from the vehicle player.
/// Standar coding documentarion can be found in 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
/// </summary>

public class P : MonoBehaviour
{
    //<summary>
    //variables globales:
    //</summary>

    //variables para la cámara
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey; //Tecla que permite cambiar entre cámaras

    //velocidad del vehículo
    public float speed = 5.0f;
    //velocidad de giro
    public float turnSpeed = 0.0f;
    //input del usuario para el movimiento con el teclado (horizontal)
    public float horizontalInput;
    //input del usuario para el movimiento con el teclado (vertical)
    public float forwardInput;

    //Variables multijugador
    public string inputId;

    /// <summary>
    /// This method is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// This method is called once per frame
    /// </summary>
    void Update()
    {
        //Capturar el input del usuario (horizontal)
        horizontalInput = Input.GetAxis("Horizontal" + inputId);

        //Capturar el input del usuario (vertical)
        forwardInput = Input.GetAxis("Vertical" + inputId);

        //Mover vehiculo hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Modificar el giro
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        //Cambio entre cámaras
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
