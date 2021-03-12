using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollision2D()
    {

        if (gameObject.CompareTag("blue"))
        {
            Debug.Log("COLLISION!!!1111");
        }
    }
}
