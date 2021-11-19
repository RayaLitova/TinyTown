using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class MinionMove : MonoBehaviour
{
    public Animator animator;
    public Transform currentPoint;
    public int currentChild;
    public float dirX;
    public float dirY;
    public float MvSpeed;
    public Rigidbody2D rb;
    public Vector2 moveDir;

    void Update()
    { 
        moveDir= new Vector2(dirX,dirY).normalized;

        if(moveDir.sqrMagnitude>0){
            animator.SetFloat("X", dirX);
            animator.SetFloat("Y", dirY);
        }
        animator.SetFloat("Speed", moveDir.sqrMagnitude);
    }

    void OnCollisionEnter2D(){
        dirX *= -1;
        dirY *= -1;
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(dirX * MvSpeed, dirY * MvSpeed); 
    }
}
