using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Animations;

public class Finish : MonoBehaviour
{
    public Animator PlayerAnimator;
    public AnimationClip SadAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //PlayerAnimator.speed = 0;
            PlayerAnimator.Play("Crying");
        }
    }
}
