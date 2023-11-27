using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;

public class ARInteractionManager : MonoBehaviour
{
    [SerializeField] private Camera ARCamera;
    private ARRaycastManager ARRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    private GameObject ARPointer;
    private GameObject model3D;
    private GameObject SelectModel;
    private bool InitialPosition;
    private bool OverUI;
    private bool is3DModelTouch;

    private Vector2 PosicionInicialTouch;
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

        if (Input.touchCount > 0)
        {
            Touch touchOne = Input.GetTouch(0);
                if(touchOne.phase == TouchPhase.Began){
                    var touchPosition = touchOne.position;
                    OverUI = TapOverUI(touchPosition);
                    is3DModelTouch = TapOverModel3D(touchPosition);
                }

                if(touchOne.phase == TouchPhase.Moved){
                    if(ARRaycastManager.Raycast(touchOne.position, hits, TrackableType.Planes))
                    {
                    Pose hitPose = hits[0].pose;
                        if(!OverUI && is3DModelTouch){
                            transform.position = hitPose.position;

                        }
                    }
                }

        if(Input.touchCount == 2)
        {
            Touch touchTwo = Input.GetTouch(1);
            if (touchOne.phase == TouchPhase.Began || touchTwo.phase == TouchPhase.Began)
            {
                PosicionInicialTouch = touchTwo.position - touchOne.position;
            }
            if (touchOne.phase == TouchPhase.Moved || touchTwo.phase == TouchPhase.Moved)
            {
                Vector2 currentTouch = touchTwo.position - touchOne.position;
                float angulo = Vector2.SignedAngle(PosicionInicialTouch, currentTouch);
                model3D.transform.rotation = Quaternion.Euler(0,model3D.transform.eulerAngles.y, 0);
                PosicionInicialTouch = currentTouch;
            }
        }
        if(is3DModelTouch && model3D == null && !OverUI)
        {
            GameManager.instance.ARPosition();
            model3D = SelectModel;
            SelectModel = null;
            ARPointer.SetActive(true);
            transform.position = model3D.transform.position;
            model3D.transform.parent = ARPointer.transform;
        }    
    }
}
    
    private bool TapOverUI(Vector2 touchPosition){

        PointerEventData evento = new PointerEventData(EventSystem.current);
        evento.position = new Vector2(touchPosition.x, touchPosition.y);

        List<RaycastResult> resultado = new List<RaycastResult>();
        EventSystem.current.RaycastAll(evento, resultado);

            return resultado.Count > 0;
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

    private bool TapOverModel3D (Vector2 touchPosition){
        Ray ray = ARCamera.ScreenPointToRay(touchPosition);

        if (Physics.Raycast(ray, out RaycastHit hit3DModel))
        {
            if(hit3DModel.collider.CompareTag("Item"))
            {
                SelectModel = hit3DModel.transform.gameObject;
                return true;
            }
        }

        return false;
    }


    public void DeleteModel()
    {
        Destroy(model3D);
        ARPointer.SetActive(false);
        GameManager.instance.MainMenu();
    }
}
