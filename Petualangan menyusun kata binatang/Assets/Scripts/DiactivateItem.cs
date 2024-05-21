using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiactivateItem : MonoBehaviour
{
    public GameObject nextHurufAtauitem;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            nextHurufAtauitem.SetActive(false);
        }
    }
}
