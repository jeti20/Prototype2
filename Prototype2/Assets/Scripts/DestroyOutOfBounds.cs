using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40; //zmienna m�wi�ca po jakiej odleg�o�ci ma znikn�� pizza
    private float lowerBound = -10; //zmienna m�wi�ca po jakiej odleg�o�ci maj� znikn�� zwierz�ta
    private float rightBound =  30; //zmienna m�wi�ca po jakiej odleg�o�ci maj� znikn�� zwierz�ta
    private float lewftBound = -30; //zmienna m�wi�ca po jakiej odleg�o�ci maj� znikn�� zwierz�ta
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //usuwanie pizzy kt�ra przeleci dalej za map� do 50m
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);//niszczy obiekt na kt�ym jest skrypt
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);//niszczy obiekt na kt�ym jest skrypt
        }
        else if (transform.position.x < lewftBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }

    }
}
