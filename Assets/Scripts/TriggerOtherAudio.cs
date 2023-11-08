using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOtherAudio : MonoBehaviour
{
    public List<AudioClip> MusicClips;
    private int musicClipsCount;
    public AudioSource MusicAudio;
    public AudioSource OtherMusic;

    private int music = 0;

    private void Start()
    {

        musicClipsCount = MusicClips.Count;
    }

    private void OnTriggerEnter(Collider collision)
    {
        GetComponent<AudioSource>().clip = MusicClips[music];
        MusicAudio.Stop();
        OtherMusic.Play();
        Debug.Log("Start OtherAudio source, stop MainMusic source");
        music = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        

        if (music == musicClipsCount)
        {
            music = 0;
        }
    }
}