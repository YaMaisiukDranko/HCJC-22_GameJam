using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Animations;

public class Finish : MonoBehaviour
{
    private Movement _movement;
    private Manager _manager;
    public Animator PlayerAnimator;
    public AnimationClip SadAnimation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _movement.StartRun = false;
            _manager.FinishMenu();
        }
    }
}
