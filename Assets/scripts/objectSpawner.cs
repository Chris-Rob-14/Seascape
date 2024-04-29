using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner : MonoBehaviour
{
   public GameObject[] Obstacle;
    public GameObject[] Collectible;
    public float spawnInterval = 1.5f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnInterval)
        {
            SpawnObject();
            timer = 0;
        }
    }

    void SpawnObject()
    {
        GameObject objToSpawn = Random.Range(0, 2) == 0 ? GetRandomObject(Obstacle) : GetRandomObject(Collectible);
        Instantiate(objToSpawn, new Vector3(Random.Range(-5, 5), 0, transform.position.z), Quaternion.identity);
    }

    GameObject GetRandomObject(GameObject[] objectsArray)
    {
        return objectsArray[Random.Range(0, objectsArray.Length)];
    }
}
