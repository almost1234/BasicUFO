using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Easter egg, wall can be destroyed within 5 hits
/// </summary>
public class FakeWall : MonoBehaviour
{
    public int BangCounter;
    AudioSource fakewallbang; // Can be serialized instead
    // Start is called before the first frame update
    void Start()
    {
        BangCounter = 0;
        fakewallbang = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Good try here, nice easter egg
        // What you didn't handle: If the game restarts I don't think the BangCounter resets to 0
        if (collision.gameObject.tag == "Player")
        {   if (BangCounter < 5)
            {
                //BangCounter = BangCounter + 1;
                BangCounter++;
                fakewallbang.Stop();
                fakewallbang.Play();
            }
            else
            {
                gameObject.SetActive(false);
            }

        }
    }

}
