using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spherePrefabs;
    public float spawnBlueX;
    public float spawnPinkX;
    public float spawnWhiteX;
    public float spawnGreenX;
    public float spawnRedX;
 
    public float spawnY;
    //private float spawnDelay = 2;

    public float spawnRate;

    // Start is called before the first frame update
    private void Awake()
    {
        SpawnSphereBlue();
        SpawnSpherePink();
        SpawnSphereWhite();
        SpawnSphereGreen();
        SpawnSphereRed();
    }

    private void Start()
    {
        InvokeRepeating("SpawnSphereWhite", spawnRate, spawnRate);
        InvokeRepeating("SpawnSphereRed", spawnRate, spawnRate);
        InvokeRepeating("SpawnSphereGreen", spawnRate, spawnRate);
        InvokeRepeating("SpawnSphereBlue", spawnRate, spawnRate);
        InvokeRepeating("SpawnSpherePink", spawnRate, spawnRate);
    }
    public void SpawnSphereBlue()
    {
        Vector3 spawnPos = new Vector3(spawnBlueX, spawnY, 0);
        //spawns the object
        Instantiate(spherePrefabs[0], spawnPos, spherePrefabs[0].transform.rotation);
    }
    public void SpawnSpherePink()
    {
        Vector3 spawnPos = new Vector3(spawnPinkX, spawnY, 0);
        //spawns the object
        Instantiate(spherePrefabs[1], spawnPos, spherePrefabs[1].transform.rotation);
    }
    public void SpawnSphereWhite()
    {
        Vector3 spawnPos = new Vector3(spawnWhiteX, spawnY, 0);
        //spawns the object
        Instantiate(spherePrefabs[2], spawnPos, spherePrefabs[2].transform.rotation);
    }
    public void SpawnSphereGreen()
    {
        Vector3 spawnPos = new Vector3(spawnGreenX, spawnY, 0);
        //spawns the object
        Instantiate(spherePrefabs[3], spawnPos, spherePrefabs[3].transform.rotation);
    }
    public void SpawnSphereRed()
    {

        Vector3 spawnPos = new Vector3(spawnRedX, spawnY, 0);
        //spawns the object
        Instantiate(spherePrefabs[4], spawnPos, spherePrefabs[4].transform.rotation);
    }
}