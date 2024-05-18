using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowUpUI : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    public GameObject earth;

    private MeshRenderer myRenderer;

    private float clip2 = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);
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
        //!TeleportRandomly();
        earth = GameObject.Find("Sphere");
        earth.transform.Rotate(1f, 0, 0, Space.World);


        FindObjectOfType<Sounds>().playSound(clip2);
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
