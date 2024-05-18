using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    private float clip5 = 5f;
    private float clip14 = 14f;

    private string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

        if (SceneName == "Pretraining")
        {
            answer3 = "17,9%";
            answer3Number = 17.9f * 0.02f;
        }

        if (SceneName == "1Modul")
        {
            answer3 = "17,9%";
            answer3Number = 17.9f * 0.02f;
        }

        if (SceneName == "2Modul")
        {
            answer3 = "2,8%";
            answer3Number = 2.8f * 0.02f;
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

    public void SceneLoader()
    {
        //yield return new WaitForSeconds(3);
        SceneManager.LoadScene("1Modul");
    }

    public void OnPointerClick()
    {
        FindObjectOfType<MyAnswerCanvasAfrica>().setAnswer(answer3, answer3Number);
        HideQuestion.SetActive(false);

        if (SceneName == "Pretraining")
        {
            FindObjectOfType<Sounds>().playSound(clip3);
            Invoke("SceneLoader", 17);
        }

        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip5);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip14);
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
