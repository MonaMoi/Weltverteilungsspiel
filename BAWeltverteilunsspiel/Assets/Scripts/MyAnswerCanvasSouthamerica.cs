using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class MyAnswerCanvasSouthamerica : MonoBehaviour
{
    public TMP_Text canvasText;
    public GameObject StatisticSouthamerica;
    private Vector3 scaleChange;
    public TMP_Text BarNumber;
    public GameObject BarDesc;

    private string SceneName;


    // Start is called before the first frame update
    void Start()
    {

        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        StatisticSouthamerica.SetActive(false);
        BarDesc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Definition of method to set answer to Canvas Text (called by CanvasUI script)
    public void setAnswer(string answer, float answerNumber)
    {
        StatisticSouthamerica.SetActive(true);
        BarDesc.SetActive(true);
        //canvasText.text = "Weltbevölkerung " + answer;
        BarNumber.text = answer;
        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticSouthamerica.transform.localScale = scaleChange;

        if (SceneName == "1Modul")
        {
            canvasText.text = "Weltbevölkerung " + answer;
        }

        if (SceneName == "2Modul")
        {
            canvasText.text = "Welteinkommen " + answer;
        }
    }
}
