using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    public GameObject[] spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        int index = Random.Range(0, spawnee.Length);
        Instantiate(spawnee[index], transform.position, transform.rotation);
      //  if (stopSpawning)
      //  {
        //    CancelInvoke("SpawnObject");
        //}
    }
    
}
