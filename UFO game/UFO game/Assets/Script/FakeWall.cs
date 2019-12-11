using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWall : MonoBehaviour

{
    public int BangCounter;
    AudioSource fakewallbang;
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
        if (collision.gameObject.tag == "Player")
        {   if (BangCounter < 5)
            {
                BangCounter = BangCounter + 1;
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
