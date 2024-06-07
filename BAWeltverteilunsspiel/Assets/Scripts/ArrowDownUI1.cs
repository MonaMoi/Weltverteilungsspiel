using UnityEngine;

public class ArrowDownUI : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    public GameObject earth;

    private MeshRenderer myRenderer;

    private float clip2 = 2f;

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

    //Method to rotate GameObject Sphere on click and calls Method "playSound" from another Script "Sound"
    public void OnPointerClick()
    {
        earth = GameObject.Find("Sphere");
        earth.transform.Rotate(-1f, 0, 0, Space.World);

        FindObjectOfType<Sounds>().playSound(clip2);
    }
}
