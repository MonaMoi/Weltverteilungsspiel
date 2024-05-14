using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource clip1;
    public AudioSource clip2;
    public AudioSource clip3;
    /*
    public AudioClip clip4;
    public AudioClip clip5;
    public AudioClip clip6;
    public AudioClip clip7;
    public AudioClip clip8;
    public AudioClip clip9;
    public AudioClip clip10;
    public AudioClip clip11;
    public AudioClip clip12;
    */

    private bool clip2Status = false;
    private bool clip3Status = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    

    public void playSound(float clipStatus)
    {
        if (clipStatus == 2 & !clip2Status)
        {
            
                //if (!clip1.isPlaying)
                //{
                    clip1.Stop(); // Rausnehmen
                    clip2.Play();
                    clip2Status = true;
                //}
                    
                
            
        }

        if (clipStatus == 3 & !clip3Status)
        {
                clip2.Stop();
                clip3.Play();
                clip3Status = true;
            
        }
    }


    /*public void playSound()
    {
        if (counter == 1)
        {
            source.PlayOneShot(clip3);
            counter = counter + 1;
        }

        if (counter == 2)
        {
            source.PlayOneShot(clip2);
            counter = counter + 1;
        }

    }*/
}
