using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gagak : MonoBehaviour
{
    private void Update()
    {
        if (FindObjectOfType<PlayerMovement>().transform.position.x > this.transform.position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
