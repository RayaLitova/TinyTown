using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public class MinionMove : MonoBehaviour
{
    public Animator animator;
    public int dirX;
    public int dirY;
    public float MvSpeed;
    public Rigidbody2D rb;
    public Vector2 moveDir;
    public MinionStats stats;

    void Start(){
        var Dir = GetTiles.Direction(gameObject);
        dirX = Dir.Item1;
        dirY = Dir.Item2;
        
        if(dirY != 0){
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }else if(dirX != 0){
            rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
    }

    void Update()
    { 
        animator.SetBool("IsCarrying", stats.isCarrying);
        
        moveDir= new Vector2(dirX,dirY).normalized;

        if(moveDir.sqrMagnitude>0){
            animator.SetFloat("X", dirX);
            animator.SetFloat("Y", dirY);
        }
        animator.SetFloat("Speed", moveDir.sqrMagnitude);
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.name == "World"){
            if(stats.isCarrying){
                Drop();
            } 
            dirX *= -1;
            dirY *= -1;
        }
        if(other.gameObject.name == "Minion"){
            Physics2D.IgnoreCollision(other.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }

    void Drop(){
        Debug.Log("Drop");
        stats.isCarrying = false;
        //a*
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(dirX * MvSpeed, dirY * MvSpeed); 
    }
}
