using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyAnswerCanvasAsia : MonoBehaviour
{
    public TMP_Text canvasText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setAnswer(string answer)
    {
        canvasText.text = answer;
    }


}
