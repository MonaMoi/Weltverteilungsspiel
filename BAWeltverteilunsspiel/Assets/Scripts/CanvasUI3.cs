using UnityEngine;
using UnityEngine.SceneManagement;

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

    // Method to load Scene
    public void SceneLoader()
    {
        SceneManager.LoadScene("1Modul");
    }

    // Call a method from another script and deliver parameter (Answer) and set bool to false to hide Question Canvas
    // Call Method "playSound" from another Script based on Current SceneName
    // Use Invoke() to call function SceneLoader with delay of 17 seconds in Pretraining-Scene
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
    }
}
