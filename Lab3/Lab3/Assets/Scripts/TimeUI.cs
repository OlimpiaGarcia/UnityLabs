using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TimeUI : MonoBehaviour
{
    //Variables globales:
    public TextMeshProUGUI timeText;


    // metodo onEnable: se ejecuta cuando el objeto se activa
    private void OnEnable()
    {
   TimeManager.OnMinuteChanged += UpdateTime;
   TimeManager.OnHourChanged += UpdateTime;
    }


    // metodo onDisable: se ejecuta cuando el objeto se desactiva
     private void OnDisable()
    {
    TimeManager.OnMinuteChanged -= UpdateTime;
    TimeManager.OnHourChanged -= UpdateTime;
    }


    //metodo UpdateTime: actualiza el tiempo en el juego
    private void UpdateTime()
    {
        timeText.text = $"{TimeManager.Hour.ToString("00")}:{TimeManager.Minute:00}";
    }
}
