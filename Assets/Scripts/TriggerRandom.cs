using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerRandom : MonoBehaviour
{
    private int countNumber;

    public AudioSource MusicAudio;
    public AudioSource JukeboxAudio;

    public AudioClip[] songClips;
    public GameObject[] clipName;

    private void OnTriggerEnter()
    {
        clipName[countNumber].SetActive(false);
        MusicAudio.Stop();

        countNumber = Random.Range(0, songClips.Length);
        Debug.Log(countNumber);
        clipName[countNumber].SetActive(true);
        JukeboxAudio.clip = songClips[countNumber];
        JukeboxAudio.Play();
    }
}