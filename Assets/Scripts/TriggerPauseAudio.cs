using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPauseAudio : MonoBehaviour
{
    public AudioSource MusicAudio;
    public AudioSource OtherAudio;

    private void OnTriggerEnter(Collider collision)
    {
        MusicAudio.Pause();
        OtherAudio.Stop();
        Debug.Log("Start MainMusic source, stop OtherAudio source");
    }

    private void OnTriggerExit(Collider other)
    {
        MusicAudio.Play();
    }
}