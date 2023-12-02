using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mov : MonoBehaviour
{
    /// Variables globales:
    
    //variables para la cámara
    public Camera mainCamera;

    //velocidad del vehículo
    public float speed = 5.0f;
    //velocidad de giro
    public float turnSpeed = 0.0f;
    //input del usuario para el movimiento con el teclado (horizontal)
    public float horizontalInput;
    //input del usuario para el movimiento con el teclado (vertical)
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
       void Update()
    {
        //Capturar el input del usuario (horizontal)
        horizontalInput = Input.GetAxis("Horizontal" );

        //Capturar el input del usuario (vertical)
        verticalInput = Input.GetAxis("Vertical" );

        //Mover vehiculo hacia adelante
        transform.Translate(Vector2.left * Time.deltaTime * speed * horizontalInput );

        //Mover vehiculo hacia arriba
        transform.Translate(Vector2.up * Time.deltaTime  * speed * verticalInput);

    }

}
