//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class MyAnswerCanvasNorthamerica : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject StatisticNorthamerica;
    private Vector3 scaleChange;
    public TMP_Text BarNumber;
    public GameObject BarDesc;

    // Start is called before the first frame update
    void Start()
    {
        StatisticNorthamerica.SetActive(false);
        BarDesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Definition of method to set answer to Canvas Text (called by CanvasUI script)
    public void setAnswer(string answer, float answerNumber)
    {
        StatisticNorthamerica.SetActive(true);
        BarDesc.SetActive(true);
        canvasText.text = "Weltbevölkerung " + answer;
        BarNumber.text = answer;
        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticNorthamerica.transform.localScale = scaleChange;
    }


}
