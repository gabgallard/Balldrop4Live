using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using extOSC;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public OSCTransmitter myTransmitter;

    void Awake()
    {
        instance = this;
    }
}
