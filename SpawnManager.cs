
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public int animalIndex;
    public int animalSpawnX;
    public float animalSpawnZ;
    
    private void Start()
    {
        animalSpawnZ = this.transform.position.z;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            animalIndex = Random.Range(0, enemies.Length);
            animalSpawnX= Random.Range(-15, 15);

            Vector3 spawnPos = new Vector3(animalSpawnX, 0, animalSpawnZ);
            Instantiate(enemies[animalIndex], spawnPos, enemies[animalIndex].transform.rotation);
        }
    }
}
