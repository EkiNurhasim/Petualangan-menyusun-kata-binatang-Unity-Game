using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckKata : MonoBehaviour
{
    public GameObject canvasBerhasil;

    public void BERHASIL()
    {
        canvasBerhasil.SetActive(true);
    }
}
