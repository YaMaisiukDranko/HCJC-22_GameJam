using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emotions : MonoBehaviour
{
    private Movement _movement;
    
    public GameObject scoreText;
    public AudioSource collectJoySound;
    
    [Header("Emotions")]
    public int joys;
    public int sadness;

    [Header("Objects")] 
    public GameObject FirstCloud;
    public GameObject SecondCloud;
    public GameObject Rain;
    public ParticleSystem RainParticleSystem;
    public GameObject Sun;
    public GameObject SunRays;

    private void Update()
    {
        ControlEmotion();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("touch " + other.tag);
        
        if (other.CompareTag("Joy"))
        {
            //collectJoySound.Play();
            joys += 1; // Add Joys
            sadness -= 1;
            print("joys = " + joys);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Sadness"))
        {
            sadness += 1; //Add Sadness
            joys -= 1;
            print("sadness = " + sadness);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Finish"))
        {
            print("Finish!");
            FinishEmotions();
        }
       
    }

    void ControlEmotion()
    {
        if (sadness > 2 && sadness > joys)
        {
            FirstCloud.SetActive(true);
            Sun.SetActive(false);
            SunRays.SetActive(false);
        }
        else if (sadness > 3 && sadness > joys)
        {
            FirstCloud.SetActive(true);
            SecondCloud.SetActive(true);
            Sun.SetActive(false);
            SunRays.SetActive(false);
        }
        else if (sadness > 4 && sadness > joys)
        {
            FirstCloud.SetActive(true);
            SecondCloud.SetActive(true);
            Rain.SetActive(true);
            RainParticleSystem.Play(true);
            Sun.SetActive(false);
            SunRays.SetActive(false);
        }

        if (joys > 1 && joys > sadness)
        {
            FirstCloud.SetActive(false);
            SecondCloud.SetActive(false);
            Sun.SetActive(true);
        }
        else if (joys > 2 && joys > sadness)
        {
            FirstCloud.SetActive(false);
            SecondCloud.SetActive(false);
            SunRays.SetActive(true);
            Sun.SetActive(true);
        }
    }

    void FinishEmotions()
    {
        FirstCloud.SetActive(false);
        SecondCloud.SetActive(false);
        Sun.SetActive(false);
        SunRays.SetActive(false);
        
        if (joys > sadness)
        {
            print("Be happy");
            _movement.PlayerAnim.Play("Silly Dancing");
        }
        else if (sadness > joys)
        {
            print("im sad");
            _movement.PlayerAnim.Play("Crying");
        }
        else if(sadness == joys)
        {
            print("50/50");
            _movement.PlayerAnim.Play("Silly Dancing");
        }
    }
}
