using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject credits;
    public GameObject daun;
    public void CreditsOn()
    {
        credits.SetActive(true);
        daun.SetActive(true);
    }

    public void CreditsOff()
    {
        credits.SetActive(false);
        daun.SetActive(false);
    }
}
