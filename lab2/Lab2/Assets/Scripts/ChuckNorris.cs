using  TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuckNorris : MonoBehaviour
{
     public TextMeshProUGUI jokeText;
    
    //llamada a la API
    public void NewJoke()
    {
        Joke j = APIHelper.GetNewJoke();
        jokeText.text = j.value;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
