using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Audio   
    public AudioSource[] audioSource;

    // MOVEMENT
    public static float speed;
    public static float jumpForce;

    // UNITY COMPONENT
    Rigidbody2D rig;
    Animator anim;

    // FX
    public GameObject dust;


    // JUMP DETECTION
    public Transform groundPos;
    private bool isGrounded;
    public float checkRadius;
    public LayerMask whatIsGround;

    //BUTTON
    private bool left;
    private bool right;
    public static bool up;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        speed = 300;
        jumpForce = 15;
        up = true;
    }

    private void FixedUpdate()
    {        

        // Ground Detection
        isGrounded = Physics2D.OverlapCircle(groundPos.position, checkRadius, whatIsGround);

        // Player Movement
        float moveInput = Input.GetAxisRaw("Horizontal");
        rig.velocity = new Vector2(moveInput * speed * Time.deltaTime, rig.velocity.y);

        // Player Movement Button Android
        if (right == true)
        {         
            rig.velocity = new Vector2(speed * Time.deltaTime, rig.velocity.y);
        }
             

        if (left == true)
        {            
            rig.velocity = new Vector2(-speed * Time.deltaTime, rig.velocity.y);
        }        
        


        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            audioSource[2].Play();
            rig.velocity = Vector2.up * jumpForce;
        }
        

        // Dust FX
        if (moveInput != 0 && isGrounded && speed != 0)
        {
            Instantiate(dust.gameObject, groundPos.position, Quaternion.identity);
        }

        // Jumping Animation
        if (!isGrounded)
        {
            anim.SetBool("jumping", true);
            Instantiate(dust.gameObject, groundPos.position, Quaternion.identity);
        }
        else
        {
            anim.SetBool("jumping", false);
        }

        // Running Animation
        if ((speed != 0 && moveInput != 0) || (speed != 0 && right) || (speed != 0 && left))
        {
            anim.SetBool("running", true);
        }        
        else
        {        
            anim.SetBool("running", false);
        }

        // Flip Player
        if ((moveInput < 0 && speed != 0) || (left == true && speed != 0)) 
            transform.eulerAngles = new Vector3(0, 180, 0);
        if ((moveInput > 0 && speed != 0) || (right == true && speed != 0))
            transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public void WalkingSFX()
    {
        int x = Random.Range(0, 2);
        switch (x)
        {
            case 0:              
                audioSource[0].Play();
                break;
            default:                
                audioSource[1].Play();
                break;
        }
    }

    public void LeftDown()
    {
        left = true;
    }

    public void LeftUp()
    {
        left = false;
    }

    public void RightDown()
    {
        right = true;
    }

    public void RightUp()
    {
        right = false;
    }

    public void Jump()
    {
        if (up == true)
        {
            if (isGrounded)
            {
                audioSource[2].Play();
                rig.velocity = Vector2.up * jumpForce;
            }
        }
    }
}
