using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject inicioCanvas;
    [SerializeField]
    private GameObject menuPrincipalCanvas;
    [SerializeField]
    private GameObject posicionModelosCanvas;
    [SerializeField]
    private GameObject deteccionCanvas;



    void Start()
    {
        GameManager.instance.OnStart += ActivateStartApp;
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;
        GameManager.instance.OnDetection += ActivateDetection;
    }

    private void ActivateDetection()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

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

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

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

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);


    }

    private void ActivateMainMenu()
    {
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(3).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        menuPrincipalCanvas.transform.GetChild(4).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

   
}
