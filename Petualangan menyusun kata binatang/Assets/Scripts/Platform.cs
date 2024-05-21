using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private Collider2D platformCollider;
    [SerializeField] private Collider2D platformTrigger;

    private CapsuleCollider2D playerCapsule;    

    void Start()
    {
        playerCapsule = GameObject.Find("Player").GetComponent<CapsuleCollider2D>();        
        Physics2D.IgnoreCollision(platformCollider, platformTrigger, true);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(platformCollider, playerCapsule, true);            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(platformCollider, playerCapsule, false);            
        }
    }
}
