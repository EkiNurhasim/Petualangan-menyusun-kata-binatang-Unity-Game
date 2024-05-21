using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointKesalahan : MonoBehaviour
{

    public Text point;
    public Text pointAkhir;
    public int pointAngka;

    void Start()
    {
        pointAngka = 0;        
    }

    private void Update()
    {
        point.text = pointAngka.ToString();
        pointAkhir.text = pointAngka.ToString(); 
    }

    public void TambahPointKesalahan()
    {
        pointAngka++;
    }
}
