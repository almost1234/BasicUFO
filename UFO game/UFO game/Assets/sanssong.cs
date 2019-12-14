using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sanssong : MonoBehaviour
{
    AudioSource playsans; // Can be serialized
    void Start()
    {
        playsans = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Good try on an easter egg
        if (collision.gameObject.tag == "Player")
        {
            playsans.Play();
        }
    }
}
