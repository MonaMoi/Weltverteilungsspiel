using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsModul2 : MonoBehaviour
{
    public AudioSource clip13;
    public AudioSource clip14;
    public AudioSource clip15;
    public AudioSource clip16;
    public AudioSource clip17;
    public AudioSource clip18;
    public AudioSource clip19;
    public AudioSource clip20;
    public AudioSource clip21;

    private bool clip14Status = false;
    private bool clip15Status = false;
    private bool clip16Status = false;
    private bool clip17Status = false;
    private bool clip18Status = false;
    private bool clip19Status = false;
    private bool clip20Status = false;
    private bool clip21Status = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void playSound(float clipStatus)
    {

        if (clipStatus == 14 & !clip14Status)
        {

            clip13.Stop();
            clip14.Play();
            clip14Status = true;

        }

        if (clipStatus == 15 & !clip15Status)
        {
            clip14.Stop();
            clip15.Play();
            clip15Status = true;

        }

        if (clipStatus == 16 & !clip16Status)
        {
            clip15.Stop();
            clip16.Play();
            clip16Status = true;

        }

        if (clipStatus == 17 & !clip17Status)
        {
            clip16.Stop();
            clip17.Play();
            clip17Status = true;

        }

        if (clipStatus == 18 & !clip18Status)
        {
            clip17.Stop();
            clip18.Play();
            clip18Status = true;

        }

        if (clipStatus == 19 & !clip19Status)
        {
            clip18.Stop();
            clip19.Play();
            clip19Status = true;

        }

        if (clipStatus == 20 & !clip20Status)
        {
            clip19.Stop();
            clip20.Play();
            clip20Status = true;

        }

        if (clipStatus == 21 & !clip21Status)
        {
            clip20.Stop();
            clip21.Play();
            clip21Status = true;

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
