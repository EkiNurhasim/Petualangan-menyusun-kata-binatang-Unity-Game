using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dust : MonoBehaviour
{
    
    void Update()
    {
        Destroy(this.gameObject, .5f);
    }
}
