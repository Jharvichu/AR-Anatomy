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
    [SerializeField] private Button buttonAddPlanes;
    [SerializeField] private Button buttonDeleteAll;

    static int CantPlane = 1;
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
            if ( planes.Count >= CantPlane ) // Comprueba si se ha alcanzado el umbral
            {
                UIManager.instance.ActivateMainMenu();
                CantPlane++;
            }
            else
            {
                UIManager.instance.ActivateDetectionIncorrect();
            }
        }
    }

    void Start()
    {
        buttonStarDetection.onClick.AddListener(StartDetection);
        buttonAddPlanes.onClick.AddListener(StartDetection);
        buttonDeleteAll.onClick.AddListener(StopPlaneDetection);
    }

    private void StartDetection()
    {
        aRPlaneManager.enabled = true;
        UIManager.instance.ActivateDetection();
    }

    public void StopPlaneDetection()
    {
        aRPlaneManager.requestedDetectionMode = UnityEngine.XR.ARSubsystems.PlaneDetectionMode.None;
        foreach (var plane in planes)
        {
            plane.gameObject.SetActive(false);
        }
        CantPlane = 0;
    }  

}
