using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Spawnee;
    public bool stopSpawning = false;
    public float SpawnTime;
    public float SpawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjeto", SpawnTime, SpawnDelay);
    }

    public void SpawnObjeto() {
        Instantiate(Spawnee, transform.position, this.transform.rotation);
        print(this.transform.position);
        if (stopSpawning) {
            CancelInvoke("SpawnObject");
        }
    }
}
