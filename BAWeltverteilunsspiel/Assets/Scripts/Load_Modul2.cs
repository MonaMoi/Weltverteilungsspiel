using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Modul2 : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    private MeshRenderer myRenderer;

    // Get the Mesh Renderer of GameObject and set color to inactive Color and bool to false on start
    void Start()
    {
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

    // Load Scene on click
    public void OnPointerClick()
    {
        SceneManager.LoadScene("2Modul");
    }
}
