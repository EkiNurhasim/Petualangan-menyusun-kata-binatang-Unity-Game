using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogGambarBerhasil : MonoBehaviour
{

    public GameObject canvasKata;
    public GameObject dialogGambarBinatang;    

    public void DiactivateAndActivate()
    {
        canvasKata.SetActive(false);
        this.gameObject.SetActive(false);
        dialogGambarBinatang.SetActive(true);
    }
}
