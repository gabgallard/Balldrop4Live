using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

public class SpawnManager : MonoBehaviour
{
    public OSCReceiver Receiver;

    public GameObject[] spherePrefabs;
    public float spawnBlueX;
    public float spawnPinkX;
    public float spawnWhiteX;
    public float spawnGreenX;
    public float spawnRedX;
 
    public float spawnY;

    public float spawnRate;
    public float spawnCooldown;

    private const string _rateAddress = "/2/spawnRate";
    private const string _gravityAddress = "/2/gravity";

    // Start is called before the first frame update

    private void Start()
    {
        Receiver.Bind(_rateAddress, ReceiveFloat);
        Receiver.Bind(_gravityAddress, ReceiveFloat);

        Receiver.Bind("/2/pauseSpawning", ReceiveInt);

        Receiver.Bind("/2/blueActivate", ReceiveInt);
        Receiver.Bind("/2/pinkActivate", ReceiveInt);
        Receiver.Bind("/2/whiteActivate", ReceiveInt);
        Receiver.Bind("/2/greenActivate", ReceiveInt);
        Receiver.Bind("/2/redActivate", ReceiveInt);
    }

    private void Update()
    {
        if (isPaused)
            return;
        spawnCooldown -= Time.deltaTime; //countdown for ball spawning
        spawnCooldown = Mathf.Min(spawnCooldown, spawnRate);
        if (spawnCooldown <= 0)
        {
            if (isBlueOn)
            { SpawnSphereBlue(); }
            if (isPinkOn)
            { SpawnSpherePink(); }
            if (isWhiteOn)
            { SpawnSphereWhite(); }
            if (isGreenOn)
            { SpawnSphereGreen(); }
            if (isRedOn)
            { SpawnSphereRed(); }

            spawnCooldown = spawnRate;
        }
    }
    public bool isBlueOn;
    public bool isPinkOn;
    public bool isWhiteOn;
    public bool isGreenOn;
    public bool isRedOn;
    public bool isPaused;
    #region SphereSpawnMethods
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
    #endregion
    public void ReceiveFloat(OSCMessage message)
    {
        print(message.Address);
        if (message.ToFloat(out var value))
        {
            switch (message.Address)
            {
                case _rateAddress:
                spawnRate = value;
                    break;
                case _gravityAddress:
                    Physics2D.gravity = new Vector2(0f, -9.81f * value);
                    break;
            }
        }
    }
    public void ReceiveInt(OSCMessage message) //receives bool from OSC
    {
        
        int value;
        if (message.ToInt(out value))
        { 
            switch (message.Address) //switches between multiple Addresses (determined inside of the Max/MSP patch)
            {
                case "/2/blueActivate":
                    isBlueOn = value !=0;
                    break;
                case "/2/pinkActivate":
                    isPinkOn = value != 0;
                    break;
                case "/2/whiteActivate":
                    isWhiteOn = value != 0;
                    break;
                case "/2/greenActivate":
                    isGreenOn = value != 0;
                    break;
                case "/2/redActivate":
                    isRedOn = value != 0;
                    break;
                case "/2/pauseSpawning": //pauses the spawning event.
                    spawnCooldown = 0.1f;
                    isPaused = value != 0;
                    break;
            }
        }
    }
}