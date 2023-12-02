using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This Follow Player class will update the movement of the camera to follow the vehicle player.
/// Standar coding documentarion can be found in 
/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/documentation-comments
/// </summary>

public class FollowPlayer : MonoBehaviour
{
    //<summary>
    //variables globales:
    //</summary>

    //variable global para el vehículo
    public GameObject player;
    //variable para la distancia entre el vehículo y la cámara
    private Vector3 offset = new Vector3(0,6,-7);
    // Start is called before the first frame update

    /// <summary>
    /// This method is called before the first frame update
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// This method: Late Update is called after Update each frame 
    /// </summary>
    void LateUpdate()
    {
        //Mover la cámara con el vehículo
        transform.position = player.transform.position + offset;
    }
}
