using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject player;
    public float moveSpeed;
    public float jumpSpeed;
    Vector2 Vector2;
    Animator anim;

    void Start()
    {
        moveSpeed = 20;
        jumpSpeed = 40;
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity == new Vector2(0, 0))
        {
            anim.enabled = false;
        }
        else
        {
            anim.enabled = true;
        }

    }
    public void RunRight()
    {
        Vector2=new Vector2(moveSpeed,0);
        rb.AddForce(Vector2);
    }
    public void RunLeft()
    {
        Vector2 = new Vector2(-moveSpeed, 0);
        rb.AddForce(Vector2);
    }
    public void jump()
    {
        if (rb.velocity.y==0)
        {
            Vector2 = new Vector2(0, jumpSpeed);
            rb.AddForce(Vector2);
        }
        else
        {
            
        }
        
    }
}
