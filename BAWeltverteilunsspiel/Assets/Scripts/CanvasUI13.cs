using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;
//using TMPro;
//using UnityEngine.UI;

public class CanvasUI13 : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;
    public GameObject myCanvas;
    public GameObject HideQuestion;

    private MeshRenderer myRenderer;
    private string answer13;
    private float answer13Number;

    private float clip9 = 9f;
    private float clip18 = 18f;


    private string SceneName;


    // Get Mesh Renderer of Object, set color of object to inactive, set method GazeAt to false, fill string with answer
    void Start()
    {
        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

      
        if (SceneName == "1Modul")
        {
            answer13 = "12,6%";
            answer13Number = 12.6f * 0.02f;
        }

        if (SceneName == "2Modul")
        {
            answer13 = "11,4%";
            answer13Number = 11.4f * 0.02f;
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

    // Definition of GazeAt Method to set highlight material if OnPointerEnter else set Original Color OnPointerExit
    private void GazeAt(bool ggazedAt)
    {
        if (InactiveColor != null && GazedAtColor != null)
        {
            myRenderer.material.color = ggazedAt ? GazedAtColor : InactiveColor;
        }
    }

    // Call a method from another script and deliver parameter (Answer) and hide Question Canvas
    public void OnPointerClick()
    {
        FindObjectOfType<MyAnswerCanvasNorthamerica>().setAnswer(answer13, answer13Number);
        HideQuestion.SetActive(false);

        
        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip9);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip18);
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
