using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARInteractionManager : MonoBehaviour
{
    [SerializeField] private Camera ARCamera;
    private ARRaycastManager ARRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private GameObject ARPointer;
    private GameObject model3D;
    private bool InitialPosition;
    public GameObject Model3D{

        set{
            model3D = value;
            model3D.transform.position = ARPointer.transform.position;
            model3D.transform.parent = ARPointer.transform;
            InitialPosition = true;
        }
    }

    void Start()
    {
        ARPointer = transform.GetChild(0).gameObject;
        ARRaycastManager = FindObjectOfType<ARRaycastManager>();
        GameManager.instance.OnMainMenu += SetPosition;
    }

    void Update()
    {
        if(InitialPosition)
        {
            Vector2 middlePointScreen = new Vector2(Screen.width / 2, Screen.height / 2);
            ARRaycastManager.Raycast(middlePointScreen, hits, TrackableType.Planes);
            if (hits.Count>0)
            {
                transform.position = hits[0].pose.position;
                transform.rotation = hits[0].pose.rotation;
                ARPointer.SetActive(true);
                InitialPosition = false;
            }
        }
    }

    private void SetPosition()
    {
        if (model3D != null)
        {
            model3D.transform.parent = null;
            ARPointer.SetActive(false);
            model3D = null;
        }
    }

    public void DeleteModel()
    {
        Destroy(model3D);
        ARPointer.SetActive(false);
        GameManager.instance.MainMenu();
    }
}
