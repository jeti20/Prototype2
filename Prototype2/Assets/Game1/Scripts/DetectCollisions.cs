using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int score;
    public static int playerScore = 0;
    public static int health = 4;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            playerScore += 1; //dodaje punkty za zabite zwierzêta
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("Niszczy gracza");
        }

        if (other.gameObject.CompareTag("Player"))
        {
            health -= 1; //dodaje punkty za zabite zwierzêta
            
            Debug.Log("Obra¿enia");
        }

    }



}
