using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]bool isGrounded = false;
    public int jumps, maxnumberofjumps;
    public bool facingRight;
    public LayerMask layerMask;
    public Transform groundcheck;
    float xinput;
    public float playerspeed = 10;
    public float playerRadius = 5;
    public float playerJumpForce = 10;


    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        facingRight = true;
    }
    void Start()
    {
        jumps = maxnumberofjumps;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded)
        {
            jumps = maxnumberofjumps;
        }
        isGrounded = Physics2D.OverlapCircle(groundcheck.position, playerRadius, layerMask);
        xinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xinput * playerspeed, rb.velocity.y);

        if (facingRight == false && xinput > 0)
        {
            Flip();
        }
        else if(facingRight == true && xinput < 0)
        {
            Flip();
        }
        if(Input.GetButtonDown("Jump") && jumps > 0)
        {
            rb.velocity = Vector2.up * playerJumpForce;
            maxnumberofjumps -= 1;
        }
        if (Input.GetButtonDown("Jump") && jumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * playerJumpForce;

        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180.0f, 0);
    }
    public void superJump()
    {
        rb.velocity = Vector2.up * playerJumpForce*1.5f;
    }
}
