using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class MoveMinion : MonoBehaviour
{
    
    public float MvSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDir;
    private float oldDirX = 1;
    public Animator animator;

    public static float moveX;
    public static float moveY;

    
    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        moveDir= new Vector2(moveX,moveY).normalized;
        if(moveX!=0)
            oldDirX = moveX;
        
        if(moveDir.sqrMagnitude>0){
            animator.SetFloat("X", moveX);
            animator.SetFloat("Y", moveY);
        }

        animator.SetFloat("Speed", moveDir.sqrMagnitude);


    }

    void FixedUpdate(){
        rb.velocity = new Vector2(moveDir.x * MvSpeed, moveDir.y * MvSpeed); 
    }
}
