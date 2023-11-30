using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.UI;

public class ModelsButton : MonoBehaviour
{
    private string modelName;
    private Sprite modelImage;
    private GameObject model3D;
    private ARInteractionManager interactionManager;
    public string ModelName { set => modelName = value; }
    public Sprite ModelImage { set => modelImage = value; }
    public GameObject Model3D { set => model3D = value; }






    // Start is called before the first frame update
    void Start()
    {
        //transform.GetChild(0).GetComponent<Text>().text = modelName;
        transform.GetChild(0).GetComponent<RawImage>().texture = modelImage.texture;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.instance.ARPosition);
        button.onClick.AddListener(Create3DModel);

        interactionManager = FindObjectOfType<ARInteractionManager>();

    }

    private void Create3DModel()
    {
        interactionManager.Model3D = Instantiate(model3D);
    }

}
