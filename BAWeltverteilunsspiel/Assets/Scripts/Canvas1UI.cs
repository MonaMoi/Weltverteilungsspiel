//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.EventSystems;
using UnityEngine;
//using TMPro;
//using UnityEngine.UI;

public class Canvas1UI : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;
    public GameObject myCanvas;
    public GameObject HideQuestion;

    private MeshRenderer myRenderer;
    private string answer1;
    private float answer1Number;
    private float clip3 = 3f;


    // Get Mesh Renderer of Object, set color of object to inactive, set method GazeAt to false, fill string with answer
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

        answer1 = "5,2%";
        answer1Number = 5.2f*0.02f;



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
        FindObjectOfType<MyAnswerCanvasAfrica>().setAnswer(answer1, answer1Number);
        HideQuestion.SetActive(false);

        FindObjectOfType<Sounds>().playSound(clip3);


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
