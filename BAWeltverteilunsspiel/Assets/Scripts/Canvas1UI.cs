using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private float clip5 = 5f;
    //private float clip14 = 14f;
    private float clip14 = 14f;



    private string SceneName;



    // Get Mesh Renderer of Object, set color of object to inactive, set method GazeAt to false, fill string with answer
    void Start()
    {
       Scene Current = SceneManager.GetActiveScene();
       SceneName = Current.name;

        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

        if (SceneName == "Pretraining")
        {
            answer1 = "5,2%";
            answer1Number = 5.2f * 0.02f;
        }

        if (SceneName == "1Modul")
        {
            answer1 = "5,2%";
            answer1Number = 5.2f * 0.02f;
        }

        if (SceneName == "2Modul")
        {
            answer1 = "20,1%";
            answer1Number = 20.1f * 0.02f;
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

    /*public void Delay()
    {
        StartCoroutine(LoadScene());

    }*/

    public void SceneLoader()
    {
        //yield return new WaitForSeconds(3);
        SceneManager.LoadScene("1Modul");
    }

    // Call a method from another script and deliver parameter (Answer) and hide Question Canvas
    public void OnPointerClick()
    {
        FindObjectOfType<MyAnswerCanvasAfrica>().setAnswer(answer1, answer1Number);
        HideQuestion.SetActive(false);

        if (SceneName == "Pretraining")
        {
            FindObjectOfType<Sounds>().playSound(clip3);
            Invoke("SceneLoader", 17);
            //StartCoroutine(SceneLoader());

            /*timer -= Time.deltaTime;

            if (timer <= 0)
            {
                SceneManager.LoadScene("1Modul");
            }*/

        }

        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip5);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip14);
        }

        /*if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip14);
        }*/


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
