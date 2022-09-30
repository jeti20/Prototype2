using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40; //zmienna mówi¹ca po jakiej odleg³oœci ma znikn¹æ pizza
    private float lowerBound = -10; //zmienna mówi¹ca po jakiej odleg³oœci maj¹ znikn¹æ zwierzêta
    private float rightBound =  30; //zmienna mówi¹ca po jakiej odleg³oœci maj¹ znikn¹æ zwierzêta
    private float lewftBound = -30; //zmienna mówi¹ca po jakiej odleg³oœci maj¹ znikn¹æ zwierzêta
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //usuwanie pizzy która przeleci dalej za mapê do 50m
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);//niszczy obiekt na któym jest skrypt
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);//niszczy obiekt na któym jest skrypt
        }
        else if (transform.position.x < lewftBound)
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }

    }
}
