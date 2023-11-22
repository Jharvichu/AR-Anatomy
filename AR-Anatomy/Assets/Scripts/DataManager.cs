using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    [SerializeField] private List<Models3D> models3d = new List<Models3D>();
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private ModelsButton modelsButton;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += CreateButtons; 
    }

    private void CreateButtons()
    {
        foreach (var model in models3d) 
        {
            ModelsButton modelbutton;
            modelbutton = Instantiate(modelsButton, buttonContainer.transform);
            modelbutton.ModelName = model.ModelName;
            modelbutton.ModelImage = model.ModelImage;
            modelbutton.Model3D = model.Model3D;
            modelbutton.name = model.ModelName;
        }
        GameManager.instance.OnMainMenu -= CreateButtons;
    }

}
