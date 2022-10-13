using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float spawnRangeX2 = 20;
    private float spawnRangeZ2 = 20;
     
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal1", Random.Range(2, 3), 1.5f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
        InvokeRepeating("SpawnRandomAnimal2", Random.Range(2, 3), 1.5f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
        InvokeRepeating("SpawnRandomAnimal3", Random.Range(2, 3), 1.5f); //bierze metodê i j¹ powstarza // wyzwyalamy funkcj, starting at 2 seconds, and we call it again every 1.5s
    }

    // Update is called once per frame
    void Update()
    {
        //tworznie zwierz¹t 
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal1();
        }
        
    }



    //funkcja ta jest wywo³ywana powy¿ej po naciœniêciu S (respi losowe zwierze 
    void SpawnRandomAnimal1()//void oznacza ze ta funkcja/metoda nie zwraca nic, tylko robi to co ma powiedziane
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);//losuje indeks zwierzêcia od 0 do 1
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ); // okreslamy gdzie maj¹ respiæ siê zwierzêta, zakres -20 - 20 na osi x i zawsze 20 na osi z
                                                                                                              //kolonuje pizze i zwraca tego klona
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[0].transform.rotation); //(zwierze z indkesem 0, w odleg³œci 20m od gracza, z rotacj¹ tak¹ jak¹ mia³ ustawiony prefab zweirzecia
        
    }

    void SpawnRandomAnimal2()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);//losuje indeks
        Vector3 spawnPosition2 = new Vector3(-spawnRangeX2, 0, Random.Range(0, spawnRangeZ2));
        Instantiate(animalPrefabs[animalIndex], spawnPosition2, animalPrefabs[0].transform.rotation * Quaternion.Euler(0, -90, 0)); 
    }

    void SpawnRandomAnimal3()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);//losuje indeks
        Vector3 spawnPosition2 = new Vector3(spawnRangeX2, 0, Random.Range(0, spawnRangeZ2));
        Instantiate(animalPrefabs[animalIndex], spawnPosition2, animalPrefabs[0].transform.rotation * Quaternion.Euler(0, 90, 0));
    }

    
}

