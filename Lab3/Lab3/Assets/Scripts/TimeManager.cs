using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeManager : MonoBehaviour
{
    //Variables globales:

    //variables Action: permiten lanzar eventos
    public static Action OnMinuteChanged;
    public static Action OnHourChanged;

    //variables Tiempo
    public static int Minute{get; private set;}
    public static int Hour{get;private set;}

    //variable para controlar el tiempo en el juego
    private float minuteToRealTime = 0.5f;

    //variable para saber el intervalo de tiempo antes de actualizar los valores
    private float timer;

    // Start is called before the first frame update
    //inicializa las variables al momento de iniciar el juego
    void Start()
    {
        Minute = 0;
        Hour = 10;
        timer = minuteToRealTime;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; //el número de fotogramas del juego corresponda al medio segundo que esperamos.

        /*Si la condición se presenta entonces aumentaremos Minute y 
        *si los minutos exceden 59 entonces sumaremos una hora a Hour. 
        *Por úlitmo si sumamos la hora reestablecemos los minutos a 0.
        */ 
        if(timer <= 0)
        {
            Minute++;

            OnMinuteChanged?.Invoke();

            if(Minute >= 60)
            {
                Minute = 0;
                Hour++;
                OnHourChanged?.Invoke();
            }

            timer = minuteToRealTime;
        }
    
    }
}
