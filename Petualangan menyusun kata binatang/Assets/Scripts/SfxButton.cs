using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxButton : MonoBehaviour
{
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlayButtonSFX()
    {
        source.Play();
    }
}
