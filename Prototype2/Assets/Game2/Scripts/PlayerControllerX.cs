using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int check;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            check = check + 1;
            if (check == 1)
            {
                StartCoroutine(LifeDog());
            }

        }
    }
    IEnumerator LifeDog()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        yield return new WaitForSeconds(1);
        check = 0;

    }
}
