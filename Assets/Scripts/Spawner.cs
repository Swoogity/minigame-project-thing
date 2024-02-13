using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // prefabs
    public GameObject[] bottomCar;
    public GameObject[] topCar;
    public GameObject[] leftCar;
    public GameObject[] rightCar;

    // timing
    public float stage1 = 3;
    public float stage2 = 6;
    public float stage3 = 9;
    public float stage4 = 12;
    public float stage5 = 15;
    public float stage6 = 18;
    private float hSpawnInterval = 1.5f;
    private float vSpawnInterval = 2.0f;
    private float vSpawnInterval2 = 2.5f;

    // start distances
    private float spawnPosX = 15.0f;
    private float spawnPosZ = 9.0f;

    // car spawn ranges
    private float CarRangeStart = 0.0f;
    private float CarRangeFinish = 4.2f;
    private float CarRangeFinishV = 10.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCarTop", stage1, hSpawnInterval);
        InvokeRepeating("SpawnRandomCarBottom", stage2, hSpawnInterval);
        InvokeRepeating("SpawnRandomCarLeft", stage3, vSpawnInterval);
        InvokeRepeating("SpawnRandomCarRight", stage4, vSpawnInterval);
        InvokeRepeating("SpawnRandomCarLeft2", stage5, vSpawnInterval2);
        InvokeRepeating("SpawnRandomCarRight2", stage6, vSpawnInterval2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // spawning cars at bottom of screen
    void SpawnRandomCarBottom()
    {
        int bCarIndex = Random.Range(0, bottomCar.Length);
        Vector3 spawnPos = new Vector3(-spawnPosX, 2, Random.Range(-CarRangeStart, -CarRangeFinish));


        Instantiate(bottomCar[bCarIndex], spawnPos, bottomCar[bCarIndex].transform.rotation);

    }

    // spawning cars at top of screen
    void SpawnRandomCarTop()
    {
        int tCarIndex = Random.Range(0, topCar.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 2, Random.Range(CarRangeStart, CarRangeFinish));


        Instantiate(topCar[tCarIndex], spawnPos, topCar[tCarIndex].transform.rotation);
    }

    // spawning cars at left side of screen
    void SpawnRandomCarLeft()
    {
        int lCarIndex = Random.Range(0, leftCar.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-CarRangeStart, -CarRangeFinishV), 2, spawnPosZ);


        Instantiate(leftCar[lCarIndex], spawnPos, leftCar[lCarIndex].transform.rotation);
    }

    // spawning cars at right side of screen
    void SpawnRandomCarRight()
    {
        int rCarIndex = Random.Range(0, rightCar.Length);
        Vector3 spawnPos = new Vector3(Random.Range(CarRangeStart, CarRangeFinishV), 2, -spawnPosZ);


        Instantiate(rightCar[rCarIndex], spawnPos, rightCar[rCarIndex].transform.rotation);
    }

    // spawning more cars at left side of screen
    void SpawnRandomCarLeft2()
    {
        int lCarIndex = Random.Range(0, leftCar.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-CarRangeStart, -CarRangeFinishV), 2, spawnPosZ);


        Instantiate(leftCar[lCarIndex], spawnPos, leftCar[lCarIndex].transform.rotation);
    }

    // spawning more cars at right side of screen
    void SpawnRandomCarRight2()
    {
        int rCarIndex = Random.Range(0, rightCar.Length);
        Vector3 spawnPos = new Vector3(Random.Range(CarRangeStart, CarRangeFinishV), 2, -spawnPosZ);


        Instantiate(rightCar[rCarIndex], spawnPos, rightCar[rCarIndex].transform.rotation);
    }
}
