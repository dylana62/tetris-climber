using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSFX : MonoBehaviour
{
    public AudioSource src;
    public AudioClip buttonClip;

    public void ButtonSound()
    {
        src.clip = buttonClip;
        src.Play();
    }
}
