using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public AudioSource clip3;

    private bool clip2Status = false;
    private bool clip3Status = false;

    // Method to play Clip based on Clip Status
    public void playSound(float clipStatus)
    {
        if (clipStatus == 2 & !clip2Status)
        {
            clip1.Stop();
            clip2.Play();
            clip2Status = true;   
        }

        if (clipStatus == 3 & !clip3Status)
        {
            clip2.Stop();
            clip3.Play();
            clip3Status = true;  
        }
    }
}
