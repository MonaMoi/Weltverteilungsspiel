using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowRealStatistic : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    private MeshRenderer myRenderer;

    public GameObject ShowReal;
    public GameObject hideButton;
    /*public GameObject AfricaReal;
    public GameObject AsiaReal;
    public GameObject EuropeReal;
    public GameObject SouthamericaReal;
    public GameObject NorthamericaReal;
    public GameObject AustraliaReal;
    public GameObject AntarticaReal;*/

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    public void OnPointerExit()
    {
        GazeAt(false);
    }

    // Definition of GazeAt Method to set highlight material if OnPointerEnter else set Original Color OnPointerExit
    private void GazeAt(bool ggazedAt)
    {
        if (InactiveColor != null && GazedAtColor != null)
        {
            myRenderer.material.color = ggazedAt ? GazedAtColor : InactiveColor;
        }
    }

    public void OnPointerClick()
    {
        ShowReal.SetActive(true);
        hideButton.SetActive(false);
    }
}
