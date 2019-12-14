using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// I see you didn't use this function in the end
[System.Obsolete]
public class SoundManager : MonoBehaviour
{

    public static AudioClip collectSound, bang1Sound, bang2Sound, breakWall;
    static AudioSource Sounds;
    void Start()
    {
        collectSound = Resources.Load<AudioClip>("cannon");

    }   

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void playmusic(string clip)
    {
        Debug.Log(clip);
        switch (clip)
        {
            case "collect":
                Sounds.PlayOneShot(collectSound);
                Debug.Log("Sound played");
                break;
            case "bangnormal":
                Sounds.PlayOneShot(bang1Sound);
                break;
            case "bangsecret":
                Sounds.PlayOneShot(bang2Sound );
                break;
            case "break":
                Sounds.PlayOneShot(breakWall );
                break;

        }
    }

}   
    
