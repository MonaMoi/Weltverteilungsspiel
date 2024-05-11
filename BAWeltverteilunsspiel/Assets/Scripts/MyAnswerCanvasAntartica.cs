//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class MyAnswerCanvasAntartica : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject StatisticAntartica;
    private Vector3 scaleChange;
    public TMP_Text BarNumber;
    public GameObject BarDesc;

    // Start is called before the first frame update
    void Start()
    {
        StatisticAntartica.SetActive(false);
        BarDesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Definition of method to set answer to Canvas Text (called by CanvasUI script)
    public void setAnswer(string answer, float answerNumber)
    {
        StatisticAntartica.SetActive(true);
        BarDesc.SetActive(true);
        canvasText.text = "Weltbevölkerung " + answer;
        BarNumber.text = answer;
        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticAntartica.transform.localScale = scaleChange;
    }
}
