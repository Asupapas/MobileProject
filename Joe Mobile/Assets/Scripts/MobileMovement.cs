using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour
{
    int mobileInput = 0;
    [SerializeField]
    float moveSpeed = 1.0f;
    Rigidbody2D rb;
    [SerializeField]
    float jumpSpeed = 1.0f;
    bool grounded = false;
    //Animator ac;
    // Start is called before the first frame update
    void Start()
    {
        //ac = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int moveDir = 0;
        int keyboardInput = (int)Input.GetAxisRaw("Horizontal");
        moveDir = keyboardInput + mobileInput;
        moveDir = Mathf.Clamp(moveDir, -1, 1);
        Vector2 velocity = rb.velocity;
        velocity.x = moveDir * moveSpeed;
        rb.velocity = velocity;
        //ac.SetFloat("xInput", moveDir);

        if (Input.GetButtonDown("Jump"))
        {
            jump();
        }
        if(moveDir > 0)
        {
            Vector3 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
        }
        if (moveDir < 0)
        {
            Vector3 scale = transform.transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
        }
    }
    public void UpdateMoveDirection(int direction)
    {
        mobileInput = direction;
    }
    public void jump()
    {
        if (grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
