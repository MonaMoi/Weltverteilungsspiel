using UnityEngine;

public class HighlightNorthAmerica : MonoBehaviour
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

    Material northAmerica;

    void Start()
    {
        // Getting Mesh Renderer Component from parent game object (sphere)
        // Set bool to false to set material when not gazing at object
        myRenderer = GetComponentInParent<MeshRenderer>();
        GazeAt(false);

        // Load Material from Resource folder 
        northAmerica = Resources.Load("North America") as Material;

        // materialsCopy becomes Array of Materials of Sphere
        // Put loaded Material on Position 6
        // Array of Materials of Sphere becomes Copy
        var materialsCopy = myRenderer.materials;
        materialsCopy[6] = northAmerica;
        myRenderer.materials = materialsCopy;

        // set bool to false to not show Continent name, Question canvas and Answer Canvas on start on Start
        descText.SetActive(false);
        CanvasShoworHideNorthamerica.SetActive(false);
        CanvasAnswers.SetActive(false);
    }

    // Method is called by the Main Camera when it starts gazing at this GameObject
    // Set active true to show Continent name and Overview with answers
    public void OnPointerEnter()
    {
        GazeAt(true);
        descText.SetActive(true);
        CanvasAnswers.SetActive(true);
    }

    // Method is called by the Main Camera when it stops gazing at this GameObject and continent name is not visible
    // Set active false to hide Continent name and Overview with answers
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
            materialsCopy[6] = highlightMaterial;
            myRenderer.materials = materialsCopy;
        }
        else
        {
            var materialsCopy = myRenderer.materials;
            materialsCopy[6] = northAmerica;
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

        if (CanvasShoworHideAfrica)
            CanvasShoworHideAfrica.SetActive(false);

        if (CanvasShoworHideAustralia)
            CanvasShoworHideAustralia.SetActive(false);

        if (CanvasShoworHideAntartica)
            CanvasShoworHideAntartica.SetActive(false);

        CanvasShoworHideNorthamerica.SetActive(true);
    }
}
