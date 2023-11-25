using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceMultiple : MonoBehaviour
{
    private PlaceIndicator placeIndicator;

    public GameObject Objeto1;
    public GameObject Objeto2;
    public GameObject Objeto3;
    public GameObject Objeto4;

    private GameObject objectToPlace;
    private GameObject CheckBeforePlace;
    private GameObject newPlacedObject;
    void Start()
    {
        placeIndicator = FindObjectOfType<PlaceIndicator> ();
    }

    public void SetObjectToPlace(GameObject objPrefab)
    {
        objectToPlace = objPrefab;
    }
    /*
    public void InstantiateObject()
    {
        Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
    } */

    public void ClickToPlaceFirst()
    {
        SetObjectToPlace(Objeto1);
    }
    public void ClickToPlaceSecond()
    {
        SetObjectToPlace(Objeto2);
    }
    public void ClickToPlaceThird()
    {
        SetObjectToPlace(Objeto3);
    }
    public void ClickToPlaceFourth()
    {
        SetObjectToPlace(Objeto4);
    }

    public void ClickToCheck()
    {
        if(objectToPlace == null)
        {
            return;
        }
        if (CheckBeforePlace != null)
        {
            Destroy(CheckBeforePlace);
        }

        CheckBeforePlace = Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
    }

    public void ClickToPlace()
    {
        if (objectToPlace == null)
        {
            return;
        }

        if (CheckBeforePlace != null)
        {
            newPlacedObject = CheckBeforePlace;
            Instantiate(newPlacedObject, CheckBeforePlace.transform.position, CheckBeforePlace.transform.rotation);
            Destroy(CheckBeforePlace);
        }
        else
        {
            Instantiate(objectToPlace, placeIndicator.transform.position, placeIndicator.transform.rotation);
        }
    }
}
