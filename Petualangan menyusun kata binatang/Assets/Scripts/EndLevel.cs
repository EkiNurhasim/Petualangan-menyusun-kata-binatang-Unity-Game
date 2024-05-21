using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour
{

    public GameObject[] hiddenWhenEndLevel;
    public GameObject canvasEndLevel;

    public void End()
    {
        foreach (var item in hiddenWhenEndLevel)
        {
            item.SetActive(false);
        }
        canvasEndLevel.SetActive(true);
    }

    
}
