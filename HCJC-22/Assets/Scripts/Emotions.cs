using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotions : MonoBehaviour
{
    public GameObject scoreText;
    public int joys;
    public AudioSource collectJoySound;

    private void OnTriggerEnter(Collider other)
    {
        print("touch " + gameObject.tag);
        if (other.CompareTag("Joy"))
        {
            //collectJoySound.Play();
            joys += 1;
            print("joys = " + joys);
        }
       
    }
}
