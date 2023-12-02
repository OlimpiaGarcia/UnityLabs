using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>

/// <summary>
/// This Move Forward class will update the movement of the vehicle player.
/// </summary>
public class MoveForward : MonoBehaviour
{
    /// Variables globales:
    ///velocidad del vehículo
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.forward * speed * Time.deltaTime);
    }
}
