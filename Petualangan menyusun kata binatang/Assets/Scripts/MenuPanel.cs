using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPanel : MonoBehaviour
{

    public GameObject canvasLevel;
    public GameObject canvasPanduan;
    public GameObject partikel;
     
    public void LevelBuka()
    {
        canvasLevel.SetActive(true);
        partikel.SetActive(true);
    }

    public void LevelTutup()
    {
        canvasLevel.SetActive(false);
        partikel.SetActive(false);
    }

    public void PanduanBuka()
    {
        canvasPanduan.SetActive(true);
        partikel.SetActive(true);
    }

    public void PanduanTutup()
    {
        canvasPanduan.SetActive(false);
        partikel.SetActive(false);
    }
}
