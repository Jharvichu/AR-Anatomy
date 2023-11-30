using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.UI;

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
    private GameObject deteccionCanvas;
    [SerializeField]
    private GameObject deteccionIncorrectCanvas;

    void Start()
    {
        
        instance = this;
        GameManager.instance.OnStart += ActivateStartApp;
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;
        GameManager.instance.OnDetection += ActivateDetection;
        GameManager.instance.OnDetectionIncorrect += ActivateDetectionIncorrect;

    }

    public void ActivateDetectionIncorrect()
    {
        //inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        //inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(4, 4, 4), 0.001f);
        //deteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.4f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.4f);

        /*
        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        */
    }

    public void ActivateDetection()
    {
        //Este canvas esta arriba, fuera de la pantalla
        inicioCanvas.transform.GetChild(0).transform.DOMoveY(5000, 0.5f);
        inicioCanvas.transform.GetChild(1).transform.DOMoveY(5000, 0.5f);

        //inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        //inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        //Este canvas aparece en la pantalla principal (escala 1)
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.1f);
        //deteccionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.001f);
        //Este canvas desaparece en el medio
        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
    }
    private void ActivateARPosition()
    {
        /*
        inicioCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        inicioCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(3, 3, 3), 0.001f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        */
        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.001f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.001f);
    }

    private void ActivateStartApp()
    {
        inicioCanvas.transform.GetChild(0).transform.DOMoveY(300, 0.5f);
        inicioCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.5f);

        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(3, 3, 3), 0.001f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.001f);

        //posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        //posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
    }

    public void ActivateMainMenu()
    {
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(3, 3, 3), 0.4f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        
        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.001f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.001f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.001f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.001f);
    }

}
