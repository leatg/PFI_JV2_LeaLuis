using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePlayer : MonoBehaviour
{
    bool jumping { get; set; } = false;
    Animator animator;
    CharacterSoundController soundController;
    // Start is called before the first frame update
    void Awake()
    {
        animator = GetComponent<Animator>();
        soundController = GetComponent<CharacterSoundController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //animator.SetBool(0, true); //IsWalking
            animator.SetBool("IsWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //animator.SetBool(0, true); //IsWalking
            animator.SetBool("IsWalkingBackwards", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("IsWalkingBackwards", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //animator.SetBool(0, true); //IsWalking
            animator.SetBool("IsWalkingLeft", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("IsWalkingLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //animator.SetBool(0, true); //IsWalking
            animator.SetBool("IsWalkingRight", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("IsWalkingRight", false);
        }


        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //animator.SetBool(0, true); //IsWalking
            animator.SetBool("IsRunning", true);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            animator.SetBool("IsRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
        }

        // if (jumping)
        // {
        //     animator.SetBool("IsJumping", true);
        // }
    }
    // public void Stop()
    // {
    //     animator.SetBool("IsJumping", false);
    //     jumping = false;
    // }
    public void PlayRunningSound()
    {
        soundController.StopSound();
        soundController.IsRunning = true;
    }
    public void PlayWalkingSound()
    {
        soundController.StopSound();
        soundController.IsWalking = true;
    }
    public void PlayAttackedSound()
    {
        soundController.StopSound();
        soundController.IsAttacked = true;
    }
}
