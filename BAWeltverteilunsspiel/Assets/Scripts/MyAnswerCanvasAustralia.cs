//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MyAnswerCanvasAustralia : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject StatisticAustralia;
    private Vector3 scaleChange;
    public TMP_Text BarNumber;
    public GameObject BarDesc;

    // Start is called before the first frame update
    void Start()
    {
        StatisticAustralia.SetActive(false);
        BarDesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Definition of method to set answer to Canvas Text (called by CanvasUI script)
    public void setAnswer(string answer, float answerNumber)
    {
        StatisticAustralia.SetActive(true);
        BarDesc.SetActive(true);
        canvasText.text = "Weltbevölkerung " + answer;
        BarNumber.text = answer;
        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticAustralia.transform.localScale = scaleChange;
    }
}
