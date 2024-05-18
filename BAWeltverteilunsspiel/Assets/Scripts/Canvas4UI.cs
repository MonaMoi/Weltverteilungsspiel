using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Canvas4UI : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;
    public GameObject myCanvas;
    public GameObject HideQuestion;

    private MeshRenderer myRenderer;
    private string answer4;
    private float answer4Number;

    private float clip6 = 6f;
    private float clip15 = 15f;


    private string SceneName;


    // Start is called before the first frame update
    void Start()
    {
        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

        if (SceneName == "1Modul")
        {
            answer4 = "59,2%";
            answer4Number = 59.2f * 0.02f;
        }

        if (SceneName == "2Modul")
        {
            answer4 = "50,4%";
            answer4Number = 50.4f * 0.02f;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        GazeAt(false);
    }

    private void GazeAt(bool ggazedAt)
    {
        if (InactiveColor != null && GazedAtColor != null)
        {
            myRenderer.material.color = ggazedAt ? GazedAtColor : InactiveColor;
        }
    }


    public void OnPointerClick()
    {
        FindObjectOfType<MyAnswerCanvasAsia>().setAnswer(answer4, answer4Number);
        HideQuestion.SetActive(false);

        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip6);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip15);
        }

        /*if (button == "Option1")
        {
            FindObjectOfType<MyAnswerCanvas>().setAnswer(answer1);
        }

        if (button == "answer2")
        {

        }

        if (button == "answer3")
        {

        }
        //!TeleportRandomly();
        //earth = GameObject.Find("Sphere");
        //earth.transform.Rotate(0, 1f, 0, Space.World);*/
    }

    /*public void GazeAt(bool gazing)
    {
        if (gazing)
        {
            myRenderer.material.color = GazedAtColor;
        }
        else
        {
            myRenderer.material.color = InactiveColor;
        }
    }*/
}
