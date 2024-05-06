using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightContinent : MonoBehaviour
{
    public Material highlightMaterial;
    private MeshRenderer myRenderer;

    Material southAmerica;

    void Start()
    {
        // Getting Mesh Renderer Component from parent game object (sphere)
        // Set bool to false to set material when not gazing at object
        myRenderer = GetComponentInParent<MeshRenderer>();
        GazeAt(false);

        // Load Material from Resource folder 
        southAmerica = Resources.Load("South America") as Material;

        // materialsCopy becomes Array of Materials of Sphere
        // Put loaded Material on Position 6
        // Array of Materials of Sphere becomes Copy
        var materialsCopy = myRenderer.materials;
        materialsCopy[5] = southAmerica;
        myRenderer.materials = materialsCopy;
    }

    void Update()
    {

    }


    /// Method is called by the Main Camera when it starts gazing at this GameObject
    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    /// Method is called by the Main Camera when it stops gazing at this GameObject
    public void OnPointerExit()
    {
        GazeAt(false);
    }

    // Definition of GazeAt Method to set highlight material if OnPointerEnter else set Original Material OnPointerExit
    private void GazeAt(bool ggazedAt)
    {
        if (ggazedAt)
        {
            var materialsCopy = myRenderer.materials;
            materialsCopy[5] = highlightMaterial;
            myRenderer.materials = materialsCopy;
        }
        else
        {
            var materialsCopy = myRenderer.materials;
            materialsCopy[5] = southAmerica;
            myRenderer.materials = materialsCopy;
        }
    }

    /*public void OnPointerClick()
    {
        //!TeleportRandomly();
        earth = GameObject.Find("Sphere");
        earth.transform.Rotate(0, 0, 1f, Space.World);
    }*/
}
