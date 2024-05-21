using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    public GameObject canvasDapatHuruf;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {    
            canvasDapatHuruf.SetActive(true);
            //Destroy(this.gameObject);

            this.gameObject.SetActive(false);
        }
    }
}
