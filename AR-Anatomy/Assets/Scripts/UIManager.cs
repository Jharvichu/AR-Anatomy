using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField]
    private GameObject inicioCanvas;
    [SerializeField]
    private GameObject menuPrincipalCanvas;
    [SerializeField]
    private GameObject posicionModelosCanvas;
    [SerializeField]
    private GameObject startdeteccionCanvas;
    [SerializeField]
    private GameObject deteccionCanvas;
    [SerializeField]
    private GameObject deteccionIncorrectCanvas;



    void Start()
    {
        instance = this;
        GameManager.instance.OnStart += ActivateStartApp;
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;
        GameManager.instance.OnStartDetection += ActivateStartDetection;
        GameManager.instance.OnDetection += ActivateDetection;
        GameManager.instance.OnDetectionIncorrect += ActivateDetectionIncorrect;
    }

    public void ActivateDetectionIncorrect()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        startdeteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        startdeteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

    public void ActivateDetection()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        startdeteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        startdeteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

    public void ActivateStartDetection()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        startdeteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        startdeteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

    private void ActivateARPosition()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        startdeteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        startdeteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateStartApp()
    {

        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        startdeteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        startdeteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);


    }

    public void ActivateMainMenu()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        startdeteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        startdeteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

   
}
