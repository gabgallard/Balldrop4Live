using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC.UI;
using extOSC;

public class ImpactSounds : MonoBehaviour
{
    public string Address;
    public string Velocity;
    public OSCButton button;
    public AudioSource mus;
    public AudioClip[] musArray;
    //public OSCTransmitter Transmitter;

    //public AudioClip sample;
    // Start is called before the first frame update

    void Awake()
    {
        //Transmitter = gameObject.FindObjectOfType<OSCTransmitter>();
        //mus = GetComponent<AudioSource>();
    }
    void Start()
    {
        //mus.playOnAwake = false;
        //GetComponent<AudioSource>().clip = sample;
    }

    // Update is called once per frame

    private AudioClip GetRandomClip()
    {
        return musArray[Random.Range(0, musArray.Length)];
    }

    void OnCollisionEnter2D(Collision2D c)  //Plays Sound Whenever collision detected
    {
     
        var velocity = new OSCMessage(Velocity);
        velocity.AddValue(OSCValue.Float(Mathf.Lerp(0, 127, c.relativeVelocity.magnitude / 14f)));
        Manager.instance.myTransmitter.Send(velocity);

        var message = new OSCMessage(Address);
        message.AddValue(OSCValue.Bool(true));

        Manager.instance.myTransmitter.Send(message);

        //button.Set(true);
        //mus.clip = GetRandomClip();
        //mus.Play();
        //GetComponent<AudioSource>().Play();
        Debug.Log(c.relativeVelocity.magnitude);

  
    }

    void OnCollisionExit2D()  //Plays Sound Whenever collision detected
    {
        //button.Set(false);
        //mus.clip = GetRandomClip();
        //mus.Play();
        //GetComponent<AudioSource>().Play();
        Debug.Log("collision detected!");
    }
}
