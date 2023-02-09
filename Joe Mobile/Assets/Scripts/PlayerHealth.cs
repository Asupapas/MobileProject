using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    public Slider slider;
    Rigidbody2D rb;
    bool grounded = false;
    // Start is called before the first frame update
    void Start()
    {
        health = 4 +PlayerPrefs.GetInt("Difficulty");
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if(otherTag == "Enemy")
        { 
                health--;
                slider.value = health;
                if (health <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                }
            
            }
        if (collision.gameObject.tag == "Lava")
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }
    
    public void easy()
    {
        PlayerPrefs.SetInt("Difficulty", 2);
    }

    public void Normal()
    {
        PlayerPrefs.SetInt("Difficulty", 0);
    }

    public void Hard()
    {
        PlayerPrefs.SetInt("Difficulty", -2);
    }

    public void Hell()
    {
        PlayerPrefs.SetInt("Difficulty", -4);
    }
}

