using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnStart;
    public event Action OnDetection;
    public event Action OnDetectionCorrect;
    public event Action OnDetectionIncorrect;
    public event Action OnMainMenu;
    public event Action OnARPosition;
    public event Action OnInformation;
    public event Action OnOption;

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


    void Start()
    {
        StartApp();
    }

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

    public void Options()
    {
        OnOption?.Invoke();
        Debug.Log("Opciones Activado");
    }

    public void Information()
    {
        OnInformation?.Invoke();
        Debug.Log("Informacion Activado");
    }

    public void Detection()
    {
        OnDetection?.Invoke();
        Debug.Log("Informacion Activado");
    }

    public void DetectionCorrect()
    {
        OnDetectionCorrect?.Invoke();
        Debug.Log("Informacion Activado");
    }

    public void DetectionIncorrect()
    {
        OnDetectionIncorrect?.Invoke();
        Debug.Log("Informacion Activado");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
