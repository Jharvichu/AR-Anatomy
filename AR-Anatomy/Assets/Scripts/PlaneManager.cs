using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class PlaneManager : MonoBehaviour
{
    [SerializeField] private ARPlaneManager aRPlaneManager;
    [SerializeField] private Button buttonStarDetection;

    private List<ARPlane> planes = new List<ARPlane>();

    private void OnEnable()
    {
        aRPlaneManager.planesChanged += PlanesFound;
    }

    private void OnDisable()
    {
        aRPlaneManager.planesChanged -= PlanesFound;
    }

    private void PlanesFound(ARPlanesChangedEventArgs planeData)
    {
        if (planeData != null && planeData.added.Count > 0)
        {
            planes.AddRange(planeData.added);
            if (planes.Count >= 3) // Comprueba si se ha alcanzado el umbral
            {
                UIManager.instance.ActivateMainMenu();
            }
        }
        else
        {
            UIManager.instance.ActivateDetectionIncorrect();
        }
    }

    void Start()
    {
        // Asegúrate de que el botón esté desactivado al inicio
        buttonStarDetection.interactable = false;

        // Agrega un listener al botón para llamar al método StartDetection cuando se presione
        buttonStarDetection.onClick.AddListener(StartDetection);
    }

    private void StartDetection()
    {
        aRPlaneManager.enabled = true;
        UIManager.instance.ActivateDetection();
    }
}
