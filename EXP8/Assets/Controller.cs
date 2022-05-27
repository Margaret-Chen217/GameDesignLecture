using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    CharacterController character;
    Vector3 moveV;
    public float gravity = 10;
    public float jumpSpeed = 5;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<CharacterController>();
    }
    void Move(){
        if(character.isGrounded){
            moveV = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            if(Input.GetKeyDown(KeyCode.Space)){
                moveV.y = jumpSpeed;
                animator.SetTrigger("Jump");
            }
            if(Input.GetKeyDown(KeyCode.U)){
                animator.SetTrigger("Attack");
            }
        }
        moveV += Vector3.down * gravity * Time.deltaTime;
        character.Move(moveV * Time.deltaTime);
        if(moveV != Vector3.zero){
            animator.SetTrigger("Walk");
        }
    }



    // Update is called once per frame
    void Update()
    {
        Move();
    }

}
