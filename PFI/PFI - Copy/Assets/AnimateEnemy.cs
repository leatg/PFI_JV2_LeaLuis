using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateEnemy : MonoBehaviour
{
    Animator animator;
    public bool IsWalking { get; set; } = false;
    public bool IsAttacking { get; set; } = false;
    public bool IsScratching { get; set; } = false;
    public bool IsIdle { get; set; } = false;
    public bool IsIdleStressed { get; set; } = false;
    public bool IsRunning { get; set; } = false;
    public bool IsDying { get; set; } = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
        IsWalking = false;
        IsIdle = true;
        //soundController = GetComponent<EnemySoundController>();
    }

    void Update()
    {
        if (IsWalking) animator.SetBool("IsWalking", true);
        else animator.SetBool("IsWalking", false);

        if (IsRunning) animator.SetBool("IsRunning", true);
        else animator.SetBool("IsRunning", false);

        if (IsDying) animator.SetBool("IsDying", true);
        else animator.SetBool("IsDying", false);

        if (IsAttacking) animator.SetBool("IsAttacking", true);

        if (IsIdle) animator.SetBool("IsIdle", true);
        else animator.SetBool("IsIdle", false);

        if (IsIdleStressed) animator.SetBool("IsIdleStressed", true);
        else animator.SetBool("IsIdleStressed", false);


    }
    //public void PlayRunningSound()
    //{
    //    soundController.StopSound();
    //    soundController.IsRunning = true;
    //}
    public void StopAttacking()
    {
        Debug.Log("Stop attacking");
        animator.SetBool("IsAttacking", false);
        animator.SetBool("IsIdle", true);
        IsAttacking = false;
    }
    public void StartedAttacking()
    {
        Debug.Log("started attcking");
        if (!IsAttacking)
            IsAttacking = true;
    }
}
