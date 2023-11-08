using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPauseAudio : MonoBehaviour
{
    public AudioSource MusicAudio;

    private void OnTriggerEnter(Collider collision)
    {
        MusicAudio.Pause();
    }

    private void OnTriggerExit(Collider other)
    {
        MusicAudio.Play();
    }
}
