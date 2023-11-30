using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnStart;
    public event Action OnDetection;
    public event Action OnDetectionIncorrect;
    public event Action OnMainMenu;
    public event Action OnARPosition;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }
    //Al iniciar, estara con el evento StarApp
    void Start()
    {
        StartApp();
    }
    //Metodos que activan los eventos
    public void StartApp()
    {
        OnStart?.Invoke();
        Debug.Log("Inicio Activado");
    }

    public void MainMenu()
    {   
        OnMainMenu?.Invoke();
        Debug.Log("Menu Principal Activado");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("ARPosicion Activado");
    }

    public void Detection()
    {
        OnDetection?.Invoke();
        Debug.Log("Deteccion Activado");
    }
    
    public void DetectionIncorrect()
    {
        OnDetectionIncorrect?.Invoke();
        Debug.Log("Deteccion Incorrecta Activado");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
