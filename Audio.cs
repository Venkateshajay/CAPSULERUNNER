using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] AudioClip Crashsfx;
    [SerializeField] AudioClip Finishsfx;
     private void OnTriggerEnter(Collider triggers)
    {
        
        if (triggers.tag=="gamefinished")
        {
            Audioplayer(Finishsfx);
        }
    }
    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            Audioplayer(Crashsfx);
        }

    }
    public void Audioplayer(AudioClip Sfx)
    {
        GetComponent<AudioSource>().PlayOneShot(Sfx);
    }
}