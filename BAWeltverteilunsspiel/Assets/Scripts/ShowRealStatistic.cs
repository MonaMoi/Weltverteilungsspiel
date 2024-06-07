using UnityEngine;
using UnityEngine.SceneManagement;


public class ShowRealStatistic : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    private MeshRenderer myRenderer;

    public GameObject ShowReal;

    public GameObject hideButton;
    public GameObject ShowButton2;

    private float clip12 = 12f;
    private float clip20 = 20f;

    private string SceneName;

    // Get Current Scene and set to variable
    // Get Mesh Renderer of Object
    // Set color of object to inactive
    // Set method GazeAt to false
    void Start()
    {
        Scene Current = SceneManager.GetActiveScene();
        SceneName = Current.name;

        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);
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

    // Call Method "playSound" from another Script based on Current SceneName
    public void OnPointerClick()
    {
        ShowReal.SetActive(true);
        hideButton.SetActive(false);
        ShowButton2.SetActive(true);

        if (SceneName == "1Modul")
        {
            FindObjectOfType<SoundsModul1>().playSound(clip12);
        }

        if (SceneName == "2Modul")
        {
            FindObjectOfType<SoundsModul2>().playSound(clip20);
        }

    }
}
