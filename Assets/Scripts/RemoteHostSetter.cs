using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using extOSC;

public class RemoteHostSetter : MonoBehaviour
{
    public Text remoteTransmitterHost;
    public Text remoteTransmitterPort;
    public OSCTransmitter Transmitter;

    void Update()
    {
        Transmitter.RemoteHost = remoteTransmitterHost.text;
        Transmitter.RemotePort = int.Parse (remoteTransmitterPort.text);
    }
}
