using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoringSystem : MonoBehaviour
{
    //Skrypt updejtuje nasz wynik na ekranie

    public GameObject scoreText; //text w UI
    public GameObject healthText; //text w UI
    
    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = "Score: " + DetectCollisions.playerScore;
        healthText.GetComponent<TextMeshProUGUI>().text = "Health: " + DetectCollisions.health;

        if (DetectCollisions.health <= 0)
        {
            SceneManager.LoadScene(0);
        }
        if (DetectCollisions.playerScore == 20)
        {
            SceneManager.LoadScene(2);
        }

    }
}
