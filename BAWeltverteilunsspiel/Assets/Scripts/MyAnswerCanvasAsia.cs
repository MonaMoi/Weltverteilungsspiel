using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyAnswerCanvasAsia : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject StatisticAsia;
    private Vector3 scaleChange;
    public TMP_Text BarNumber;
    public GameObject BarDesc;

    // Start is called before the first frame update
    void Start()
    {
        StatisticAsia.SetActive(false);
        BarDesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setAnswer(string answer, float answerNumber)
    {
        StatisticAsia.SetActive(true);
        BarDesc.SetActive(true);
        canvasText.text = "Weltbevölkerung " + answer;
        BarNumber.text = answer;
        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticAsia.transform.localScale = scaleChange;
    }


}
