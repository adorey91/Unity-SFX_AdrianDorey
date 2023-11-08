using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource SFX;

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("something collided");
        SFX.Play();
    }
}
