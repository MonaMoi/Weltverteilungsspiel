using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MyAnswerCanvasAsia : MonoBehaviour
{
    public TMP_Text canvasText;

    public GameObject StatisticAsia;

    private Vector3 scaleChange;

    public TMP_Text BarNumber;
    public GameObject BarDesc;

    private string SceneName;

    // Get Current Scene and set to variable
    // Set active false for several objects to hide them on start
    void Start()
    {
        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        StatisticAsia.SetActive(false);
        BarDesc.SetActive(false);
    }

    // Definition of method to set answer to Canvas Text (called by CanvasUI script)
    // Transform Scale of GameObject based on answer
    // Set active true for several Objects to show them 
    public void setAnswer(string answer, float answerNumber)
    {
        StatisticAsia.SetActive(true);
        BarDesc.SetActive(true);

        BarNumber.text = answer;

        scaleChange = new Vector3(1, answerNumber, 1);
        StatisticAsia.transform.localScale = scaleChange;

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
