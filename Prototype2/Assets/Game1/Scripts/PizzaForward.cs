using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaForward : MonoBehaviour
{//Scrip makes pizza fly forward
    public float speed = 40.0f;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
