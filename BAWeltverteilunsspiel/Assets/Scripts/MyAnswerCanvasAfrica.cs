//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class MyAnswerCanvasAfrica : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject StatisticAfrica;
    private Vector3 scaleChange;
    public TMP_Text BarNumber;
    public GameObject ShowCanvasStatistics;
    public GameObject BarDesc;
    public GameObject HideRealStatistic;

    // Start is called before the first frame update
    void Start()
    {
        ShowCanvasStatistics.SetActive(false);
        StatisticAfrica.SetActive(false);
        BarDesc.SetActive(false);
        HideRealStatistic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Definition of method to set answer to Canvas Text (called by CanvasUI script)
    public void setAnswer(string answer, float answerNumber)
    {
        ShowCanvasStatistics.SetActive(true);
        StatisticAfrica.SetActive(true);
        BarDesc.SetActive(true);
        canvasText.text = "Weltbevölkerung " + answer;
        BarNumber.text = answer;
        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticAfrica.transform.localScale = scaleChange;
    }


}
