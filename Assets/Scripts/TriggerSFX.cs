using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource SFX;

    private void OnTriggerEnter(Collider collision)
    {
        SFX.Play();
    }
}