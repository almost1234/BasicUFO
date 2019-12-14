using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Standard audio control for on collision with wall
/// </summary>
public class WallBang : MonoBehaviour
{
    
    AudioSource wallbang;
    // Start is called before the first frame update
    void Start()
    {
       
        wallbang = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            wallbang.Stop();
            wallbang.Play();
        }

        
    }



}




