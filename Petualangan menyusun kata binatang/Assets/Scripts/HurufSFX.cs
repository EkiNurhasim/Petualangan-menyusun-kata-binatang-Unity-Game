using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurufSFX : MonoBehaviour
{
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlaySFX()
    {
        source.Play();
    }
}
