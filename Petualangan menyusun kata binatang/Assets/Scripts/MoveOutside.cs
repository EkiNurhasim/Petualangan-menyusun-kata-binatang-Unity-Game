using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOutside : MonoBehaviour
{
    public GameObject kameraSebelum;
    public GameObject kameraSesudah;    
    public Animator animatorTransitionCanvas;
    public Transform playerMovePoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(LoadTransition());
        }
    }

    IEnumerator LoadTransition()
    {
        animatorTransitionCanvas.SetTrigger("Start");
        yield return new WaitForSeconds(.5f);
        FindObjectOfType<PlayerMovement>().transform.position = playerMovePoint.transform.position;

        kameraSebelum.SetActive(false);
        kameraSesudah.SetActive(true);
    }
}