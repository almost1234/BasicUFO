using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    AudioSource collectibles;
    public float speed;
    public Text countText;
    public Text winText;
    public bool action; // Using boolean to check if process input or not

    
    public GameObject Collectibles;
    public GameObject PauseMenu;
    public GameObject TitleScreen;
    public GameObject WinScreen;
    private Rigidbody2D rb2d;
    private int count;

    // Standard monobehaviour code initialize
    void Start()
    {
        collectibles = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        winText.text = "";
        action = false;
        PauseMenu.SetActive(false);
        countText.text = "";
    }

    public void actionChanger()
    {
        if (action == false)
        {
            action = true;
        }
        else
        {
            action = false;
        }
    }

    void FixedUpdate()
    {
        // Process input
        if (action == true)
        {
            gameObject.SetActive(action);
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb2d.AddForce(movement * speed);
            

        }

    }
    public void restart()
    {

        foreach (Transform child in Collectibles.transform)
        {
            child.gameObject.SetActive(true);
        }
        gameObject.transform.position = new Vector3(0, 0, 0);
        rb2d.velocity = new Vector2(0.0f, 0.0f);
        rb2d.angularVelocity = 0.0f;
        count = 0;
        countText.text = "Count: " + count.ToString();
  

    }

    public void pauseChanger() {
        if (PauseMenu.gameObject.activeSelf)
        {
            PauseMenu.SetActive(false);
            actionChanger();
            Time.timeScale = 1;
        }
        else
        {
            PauseMenu.SetActive(true);
            actionChanger();
            Time.timeScale = 0;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown("escape") && TitleScreen.activeSelf == false)
        {
            if (PauseMenu.activeSelf)
            {
                pauseChanger();
            }
            else
            {
                pauseChanger();
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp")) // Fix your tabbing
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            collectibles.Play();
        } // Delete unnecessary spaces
    }
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            rb2d.velocity = new Vector2(0.0f, 0.0f);
            rb2d.angularVelocity = 0.0f;
            winText.text = "YOU WIN!";
            WinScreen.SetActive(true);
            action = false;
            countText.text = "";
        } // Fix your brackets
    }
}
   