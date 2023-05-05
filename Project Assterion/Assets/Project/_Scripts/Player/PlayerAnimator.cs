using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;

    private const string IDLE_DOWN = "player_idle_down";
    private const string IDLE_UP = "player_idle_up";
    private const string IDLE_LEFT = "player_idle_left";
    private const string IDLE_RIGHT = "player_idle_right";
    
    private const string RUN_DOWN = "player_run_down";
    private const string RUN_UP = "player_run_up";
    private const string RUN_LEFT = "player_run_left";
    private const string RUN_RIGHT = "player_run_right";
    
    

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        animator.Play(IDLE_DOWN);
    }


    public void PlayAnimation(Vector2 direction, Vector2 lastDirection)
    {
        if (direction.x > 0.1f)
        {
            animator.Play(RUN_RIGHT);
        }
        else if (direction.x < -0.1f)
        {
            animator.Play(RUN_LEFT);
        }
        else if (direction.y > 0.1f)
        {
            animator.Play(RUN_UP);
        }
        else if (direction.y < -0.1f)
        {
            animator.Play(RUN_DOWN);
        }
        else
        {
            if (lastDirection.x > 0.1f)
            {
                animator.Play(IDLE_RIGHT);
            }
            else if (lastDirection.x < -0.1f)
            {
                animator.Play(IDLE_LEFT);
            }
            else if (lastDirection.y > 0.1f)
            {
                animator.Play(IDLE_UP);
            }
            else if (lastDirection.y < -0.1f)
            {
                animator.Play(IDLE_DOWN);
            }
        }
    }



}
