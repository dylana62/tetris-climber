using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSFX : MonoBehaviour
{
    public AudioSource src;
    public AudioClip move;
    public AudioClip hardDrop;
    public AudioClip lockPiece;
    public AudioClip explosion;
    public AudioClip punch;

    public void PlaySFX(AudioClip clip) {
        src.PlayOneShot(clip);
    }
}
