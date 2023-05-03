using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public float movespeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator animator;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        //Debug.Log(movement.x + ":" + movement.y);  
        //tinh do dai vector khi di chuyen ,gia tri nay thuong duong
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement*movespeed*Time.fixedDeltaTime);
    }
}
