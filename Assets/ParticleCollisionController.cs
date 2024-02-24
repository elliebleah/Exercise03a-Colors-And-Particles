using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionController : MonoBehaviour
{
    public ParticleSystem particleSystem;

    void Start()
    {
        //particleSystem = GetComponent<ParticleSystem>();
        particleSystem.Stop(); // Ensure the particle system starts off inactive
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if collision occurs with the object you want to trigger the particle system
        if (collision.gameObject.CompareTag("ball"))
        {
            // Start emitting particles if the particle system is not already playing
            if (!particleSystem.isPlaying)
            {
                particleSystem.Play();
            }
        }
    }

   
}
