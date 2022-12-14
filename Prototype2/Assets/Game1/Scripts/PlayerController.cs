using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float xRange = 20f;
    public float zRange = 20f;
    public float zRangeBack = 0f;
    public float speed = 20f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);



        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        if (transform.position.z < zRangeBack)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeBack);
        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            //kolonuje pizze i zwraca tego klona
            //transform.position --> bo chcemy zeby respi�o si� w pozycji obiketu kt�ry ma na sobie skrypt, w tym przypadku jest to player
            //projectilePrefab.transform.rotation --> mamy ustawiony ju� prefab pizzy i nie chcemy innej rotacji, czyli piszemy, ze rotacja taka jak prefaba pizzy
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnerNaPlayerontroller");
    }
}