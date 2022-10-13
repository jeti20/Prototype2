using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kurwa : MonoBehaviour
{
    public static int health = 4;
    private void OnTriggerEnter(Collider other)
    {
        health-= 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Health= " + health);
    }
}
