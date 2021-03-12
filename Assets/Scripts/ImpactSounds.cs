using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactSounds : MonoBehaviour
{

    public AudioSource mus;
    public AudioClip[] musArray;
    //public AudioClip sample;
    // Start is called before the first frame update

    void Awake()
    {
        mus = GetComponent<AudioSource>();
    }
    void Start()
    {
        mus.playOnAwake = false;
        //GetComponent<AudioSource>().clip = sample;
    }

    // Update is called once per frame

    private AudioClip GetRandomClip()
    {
        return musArray[Random.Range(0, musArray.Length)];
    }

    void OnCollisionEnter2D()  //Plays Sound Whenever collision detected
    {
        mus.clip = GetRandomClip();
        mus.Play();
        //GetComponent<AudioSource>().Play();
        Debug.Log("collision detected!");
    }
}
