//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class HighlightAfrica : MonoBehaviour
{
    public Material highlightMaterial;
    private MeshRenderer myRenderer;

    public GameObject descText;

    public GameObject CanvasShoworHideAfrica;
    public GameObject CanvasShoworHideAsia;
    public GameObject CanvasShoworHideEurope;
    public GameObject CanvasShoworHideSouthamerica;
    public GameObject CanvasShoworHideNorthamerica;
    public GameObject CanvasShoworHideAustralia;
    public GameObject CanvasShoworHideAntartica;


    public GameObject CanvasAnswers;

    Material africa;

    void Start()
    {
        // Getting Mesh Renderer Component from parent game object (sphere)
        // Set bool to false to set material when not gazing at object
        myRenderer = GetComponentInParent<MeshRenderer>();
        GazeAt(false);

        // Load Material from Resource folder 
        africa = Resources.Load("Africa") as Material;

        // materialsCopy becomes Array of Materials of Sphere
        // Put loaded Material on Position 3
        // Array of Materials of Sphere becomes Copy
        var materialsCopy = myRenderer.materials;
        materialsCopy[3] = africa;
        myRenderer.materials = materialsCopy;

        // set bool to false to not show Continent name, Question canvas and Answer Canvas on start on Start
        descText.SetActive(false);
        CanvasShoworHideAfrica.SetActive(false);
        CanvasAnswers.SetActive(false);
    }

    void Update()
    {

    }


    /// Method is called by the Main Camera when it starts gazing at this GameObject and Continent name is visible
    public void OnPointerEnter()
    {
        GazeAt(true);

        descText.SetActive(true);
        
        CanvasAnswers.SetActive(true);
    }

    /// Method is called by the Main Camera when it stops gazing at this GameObject and continent name is not visible
    public void OnPointerExit()
    {
        GazeAt(false);

        descText.SetActive(false);

        CanvasAnswers.SetActive(false);
    }

    // Definition of GazeAt Method to set highlight material if OnPointerEnter else set Original Material OnPointerExit
    private void GazeAt(bool ggazedAt)
    {
        if (ggazedAt)
        {
            var materialsCopy = myRenderer.materials;
            materialsCopy[3] = highlightMaterial;
            myRenderer.materials = materialsCopy;
        }
        else
        {
            var materialsCopy = myRenderer.materials;
            materialsCopy[3] = africa;
            myRenderer.materials = materialsCopy;
        }
    }

    // Check if Question Canvas from different continents are visible and hide it, else show Question Canvas of pointed continent
    public void OnPointerClick()
    {
        if (CanvasShoworHideAsia)
            CanvasShoworHideAsia.SetActive(false);

        if (CanvasShoworHideEurope)
            CanvasShoworHideEurope.SetActive(false);

        if (CanvasShoworHideSouthamerica)
            CanvasShoworHideSouthamerica.SetActive(false);

        if (CanvasShoworHideNorthamerica)
            CanvasShoworHideNorthamerica.SetActive(false);

        if (CanvasShoworHideAustralia)
            CanvasShoworHideAustralia.SetActive(false);

        if (CanvasShoworHideAntartica)
            CanvasShoworHideAntartica.SetActive(false);


        CanvasShoworHideAfrica.SetActive(true);
        
        //!TeleportRandomly();
        // CanvasShoworHide = GameObject.Find("Canvas1");
        // CanvasShoworHide.SetActive(true);
    }

    
}
