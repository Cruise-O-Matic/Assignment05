using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{

    public Text text;
    public float fallSpeed = 1f;
    static int lives = 5;
    public AudioSource clickySound;
    public static int typedLetters;
    public static int correctLetters;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        correctLetters++;
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
     }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);

        if (Input.anyKeyDown)
        {
            clickySound.Play();
            typedLetters++;
        }
    }
    
    
    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
        Debug.Log("Word destroyed");
        lifeCounter();
    }

    public void lifeCounter()
    {
        lives--;
        if (lives == 0)
        {
            Debug.Log("GAME OVER");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            lives = 5;
        }
    }

}
