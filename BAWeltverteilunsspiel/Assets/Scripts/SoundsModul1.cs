using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsModul1 : MonoBehaviour
{
    public AudioSource clip4;
    public AudioSource clip5;
    public AudioSource clip6;
    public AudioSource clip7;
    public AudioSource clip8;
    public AudioSource clip9;
    public AudioSource clip10;
    public AudioSource clip11;
    public AudioSource clip12;
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

    private bool clip5Status = false;
    private bool clip6Status = false;
    private bool clip7Status = false;
    private bool clip8Status = false;
    private bool clip9Status = false;
    private bool clip10Status = false;
    private bool clip11Status = false;
    private bool clip12Status = false;

    // Start is called before the first frame update
    void Start()
    {
    }



    public void playSound(float clipStatus)
    {

        if (clipStatus == 5 & !clip5Status)
        {

            clip4.Stop();
            clip5.Play();
            clip5Status = true;

        }

        if (clipStatus == 6 & !clip6Status)
        {
            clip5.Stop();
            clip6.Play();
            clip6Status = true;

        }

        if (clipStatus == 7 & !clip7Status)
        {
            clip6.Stop();
            clip7.Play();
            clip7Status = true;

        }

        if (clipStatus == 8 & !clip8Status)
        {
            clip7.Stop();
            clip8.Play();
            clip8Status = true;

        }

        if (clipStatus == 9 & !clip9Status)
        {
            clip8.Stop();
            clip9.Play();
            clip9Status = true;

        }

        if (clipStatus == 10 & !clip10Status)
        {
            clip9.Stop();
            clip10.Play();
            clip10Status = true;

        }

        if (clipStatus == 11 & !clip11Status)
        {
            clip10.Stop();
            clip11.Play();
            clip11Status = true;

        }

        if (clipStatus == 12 & !clip12Status)
        {
            clip11.Stop();
            clip12.Play();
            clip12Status = true;

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
