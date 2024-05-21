using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInside : MonoBehaviour
{
    public GameObject ButtonMasuk;
    public GameObject kameraSebelum;
    public GameObject kameraSesudah;
    public GameObject alert;
    public Animator animatorTransitionCanvas;
    public Transform playerMovePoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            alert.SetActive(true);
            ButtonMasuk.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(LoadTransition());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            alert.SetActive(false);
            ButtonMasuk.SetActive(false);
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

    public void Masuk()
    {
        StartCoroutine(LoadTransition());
    }
}
