using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFrames : MonoBehaviour
{
    // Move Player and Move Scene Frames
    public GameObject kameraSebelum;
    public GameObject kameraSesudah;
    public Transform movePoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = movePoint.transform.position;
            kameraSebelum.SetActive(false);
            kameraSesudah.SetActive(true);
        }
    }
}
