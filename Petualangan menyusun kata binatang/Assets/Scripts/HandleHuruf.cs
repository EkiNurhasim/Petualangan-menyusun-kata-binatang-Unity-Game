using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleHuruf : MonoBehaviour
{

    public GameObject[] huruf4;
    public GameObject[] canvasDiactivate;    

    public void Diactivate()
    {
        foreach (var item in canvasDiactivate)
        {
            item.SetActive(false);
        }
    }
    
    public void HURUF1()
    {
        huruf4[0].SetActive(true);
    }

    public void HURUF2()
    {
        huruf4[1].SetActive(true);
    }

    public void HURUF3()
    {
        huruf4[2].SetActive(true);
    }

    public void HURUF4()
    {
        huruf4[3].SetActive(true);
    }

}
