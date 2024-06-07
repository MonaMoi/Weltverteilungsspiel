using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasUI15 : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    public GameObject myCanvas;
    public GameObject HideQuestion;

    private MeshRenderer myRenderer;

    private string answer15;
    private float answer15Number;

    private float clip9 = 9f;
    private float clip18 = 18f;

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
            answer15 = "4,7%";
            answer15Number = 4.7f * 0.02f;
        }

        if (SceneName == "2Modul")
        {
            answer15 = "28,0%";
            answer15Number = 28.0f * 0.02f;
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
        FindObjectOfType<MyAnswerCanvasNorthamerica>().setAnswer(answer15, answer15Number);
        HideQuestion.SetActive(false);

        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip9);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip18);
        }
    }
}
