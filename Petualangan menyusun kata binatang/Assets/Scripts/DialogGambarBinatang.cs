using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogGambarBinatang : MonoBehaviour
{    
    public GameObject canvasKata;    
   
    public void DiactivateObjectItSelf()
    {
        this.gameObject.SetActive(false);
        canvasKata.SetActive(true);
    }
}
