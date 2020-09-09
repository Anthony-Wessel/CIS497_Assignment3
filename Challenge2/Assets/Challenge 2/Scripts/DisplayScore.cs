using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    public static int score;
    public static int maxHealth;
    public static int currentHealth;
    Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        maxHealth = 5;
        currentHealth = maxHealth;
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 5)
        {
            scoreText.text = "You win!\n"
                            + "Press R to play again!";
            if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(0);
        }
        else if (currentHealth <= 0)
        {
            scoreText.text = "You lose!\n"
                            + "Press R to try again!";
            if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(0);
        }
        else
        {
            scoreText.text = "Score: " + score + "\n"
            + "Health: " + currentHealth + "/" + maxHealth;
        }
    }
}
