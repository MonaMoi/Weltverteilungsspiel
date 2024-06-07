using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas5UI : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    public GameObject myCanvas;
    public GameObject HideQuestion;

    private MeshRenderer myRenderer;

    private string answer5;
    private float answer5Number;

    private float clip6 = 6f;
    private float clip15 = 15f;

    private string SceneName;

    // Get Current Scene and set to variable
    // Get Mesh Renderer of Object
    // Set color of object to inactive
    // Set method GazeAt to false
    // Fill variables with answer based on Scnene name
    void Start()
    {
        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);


        if (SceneName == "1Modul")
        {
            answer5 = "36,5%";
            answer5Number = 36.5f * 0.02f;
        }

        if (SceneName == "2Modul")
        {
            answer5 = "21,9%";
            answer5Number = 21.9f * 0.02f;
        }
    }

    // Method is called by the Main Camera when it starts gazing at this GameObject
    public void OnPointerEnter()
    {
        GazeAt(true);
    }

    // Method is called by the Main Camera when it stops gazing at this GameObject
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

    // Call a method from another script and deliver parameter (Answer) and set bool to false to hide Question Canvas
    // Call Method "playSound" from another Script based on Current SceneName
    public void OnPointerClick()
    {
        FindObjectOfType<MyAnswerCanvasAsia>().setAnswer(answer5, answer5Number);
        HideQuestion.SetActive(false);

        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip6);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip15);
        }
    }
}
