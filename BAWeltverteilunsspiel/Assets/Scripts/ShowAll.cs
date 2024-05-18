using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowAll : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    public GameObject hideButton;
    public GameObject Modul1;

    private float clip21 = 21f;


    public GameObject hideAfricaStatistics;
    public GameObject hideAfricaNumber;
    public GameObject hideAfricaDollar;
    public GameObject hideAsiaStatistics;
    public GameObject hideAsiaNumber;
    public GameObject hideAsiaaDollar;
    public GameObject hideEuropeStatistics;
    public GameObject hideEuropeNumber;
    public GameObject hideEuropeDollar;
    public GameObject hideSouthamericaStatistics;
    public GameObject hideSouthamericaNumber;
    public GameObject hideSouthamericaDollar;
    public GameObject hideNorthamericaStatistics;
    public GameObject hideNorthamericaNumber;
    public GameObject hideNorthamericaDollar;
    public GameObject hideAustraliaStatistics;
    public GameObject hideAustraliaNumber;
    public GameObject hideAustraliaDollar;

    private MeshRenderer myRenderer;


    Material africa;
    public GameObject BarAfrica;
    Material asia;
    public GameObject BarAsia;
    Material europe;
    public GameObject BarEurope;
    Material southamerica;
    public GameObject BarSouthamerica;
    Material northamerica;
    public GameObject BarNorthamerica;
    Material australia;
    public GameObject BarAustralia;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

        africa = Resources.Load("Africa") as Material;
        asia = Resources.Load("Asia") as Material;
        europe = Resources.Load("Europe") as Material;
        southamerica = Resources.Load("South America") as Material;
        northamerica = Resources.Load("North America") as Material;
        australia = Resources.Load("Australia") as Material;
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
        Modul1.SetActive(true);
        hideButton.SetActive(false);

        FindObjectOfType<SoundsModul2>().playSound(clip21);

        hideAfricaStatistics.SetActive(false);
        hideAfricaNumber.SetActive(false);
        hideAfricaDollar.SetActive(false);
        hideAsiaStatistics.SetActive(false);
        hideAsiaNumber.SetActive(false);
        hideAsiaaDollar.SetActive(false);
        hideEuropeStatistics.SetActive(false);
        hideEuropeNumber.SetActive(false);
        hideEuropeDollar.SetActive(false);
        hideSouthamericaStatistics.SetActive(false);
        hideSouthamericaNumber.SetActive(false);
        hideSouthamericaDollar.SetActive(false);
        hideNorthamericaStatistics.SetActive(false);
        hideNorthamericaNumber.SetActive(false);
        hideNorthamericaDollar.SetActive(false);
        hideAustraliaStatistics.SetActive(false);
        hideAustraliaNumber.SetActive(false);
        hideAustraliaDollar.SetActive(false);

        BarAfrica.GetComponent<MeshRenderer>().material = africa;
        BarAsia.GetComponent<MeshRenderer>().material = asia;
        BarEurope.GetComponent<MeshRenderer>().material = europe;
        BarSouthamerica.GetComponent<MeshRenderer>().material = southamerica;
        BarNorthamerica.GetComponent<MeshRenderer>().material = northamerica;
        BarAustralia.GetComponent<MeshRenderer>().material = australia;

    }
}
