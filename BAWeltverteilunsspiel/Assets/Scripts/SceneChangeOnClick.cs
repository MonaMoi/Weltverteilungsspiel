using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnClick : MonoBehaviour
{
    public Color InactiveColor;
    public Color GazedAtColor;

    private MeshRenderer myRenderer;

    //FadeInOut fade;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRenderer.material.color = InactiveColor;
        GazeAt(false);

       // fade = FindObjectOfType<FadeInOut>();
    }

   /* public IEnumerator ChangeScene()
    {
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("2Modul");
    }*/

 
    public void OnPointerEnter()
    {
        GazeAt(true);
    }

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

    public void OnPointerClick()
    {
        //StartCoroutine(ChangeScene());
        SceneManager.LoadScene("2Modul");
    }
}
