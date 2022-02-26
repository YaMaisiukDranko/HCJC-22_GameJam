using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotions : MonoBehaviour
{
    public GameObject scoreText;
    public AudioSource collectJoySound;
    
    [Header("Emotions")]
    public int joys;
    public int sadness;
    

    private void OnTriggerEnter(Collider other)
    {
        print("touch " + other.tag);
        
        if (other.CompareTag("Joy"))
        {
            //collectJoySound.Play();
            joys += 1; // Add Joys
            print("joys = " + joys);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Sadness"))
        {
            sadness += 1; //Add Sadness
            print("sadness = " + sadness);
            Destroy(other.gameObject);
        }
       
    }
}
