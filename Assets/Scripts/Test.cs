using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using extOSC.UI;

public class Test : MonoBehaviour
{
    //public Button button;

    void Update()
    {
        GetComponent<OSCButton>().Set(Input.GetKey(KeyCode.Space));
    }
}
