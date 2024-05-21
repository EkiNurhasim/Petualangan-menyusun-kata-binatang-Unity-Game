using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurufSalah : MonoBehaviour
{
    public GameObject hurufSalah;
    public void HurufSalahOn()
    {
        hurufSalah.SetActive(true);
    }

    public void HurufSalahOff()
    {
        hurufSalah.SetActive(false);
    }
}
