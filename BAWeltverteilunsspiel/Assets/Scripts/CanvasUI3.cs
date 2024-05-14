using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Canvas3UI : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;
    public GameObject myCanvas;
    public GameObject HideQuestion;

    private MeshRenderer myRenderer;
    private string answer3;
    private float answer3Number;
    private float clip3 = 3f;


    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

        answer3 = "17,9%";
        answer3Number = 17.9f * 0.02f;

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
        FindObjectOfType<MyAnswerCanvasAfrica>().setAnswer(answer3, answer3Number);
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
