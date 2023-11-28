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

        //AnimacionesAuxiliares
    }

    public void ActivateDetectionIncorrect()
    {
        //Este canvas se expande
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(3, 3, 3), 0.1f);
        //Este canvas aparece del medio
        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);

        //menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        //posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        //posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

    public void ActivateDetection()
    {
        //Este canvas esta arriba, fuera de la pantalla
        inicioCanvas.transform.GetChild(0).transform.DOMoveY(2000, 0.3f);
        inicioCanvas.transform.GetChild(1).transform.DOMoveY(2000, 0.3f);
        //Este canvas aparece en la pantalla principal (escala 1)
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        //Este canvas desaparece en el medio
        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.1f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.1f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.5f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }
    private void ActivateARPosition()
    {
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.0003f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.0003f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.0003f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.005f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.005f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.005f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
    }

    private void ActivateStartApp()
    {
        //El canvas de inicio esta en la pantalla
        inicioCanvas.transform.GetChild(0).transform.DOMoveY(300, 0.5f);
        inicioCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.5f);
        //Los demas canvas esta con escala 0
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.01f);

        deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.01f);
        deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.01f);

        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.1f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.1f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.1f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.01f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.01f);

    }

    public void ActivateMainMenu()
    {
        //Este canvas desaparece agrandandose desde el centro
        deteccionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(3, 3, 3), 0.1f);
        //
        //deteccionIncorrectCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        //deteccionIncorrectCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        
        menuPrincipalCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.01f);
        menuPrincipalCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.01f);
        menuPrincipalCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.01f);

        posicionModelosCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        posicionModelosCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
    }

}
