using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    private GeneralControls keyboardControls;

    private void Awake()
    {
        keyboardControls = new GeneralControls();
        keyboardControls.Keyboard.DestroyBalls.performed += _ => DestroyObject();
    }

    private void OnEnable()
    {
        keyboardControls.Enable();
    }

    private void OnDisable()
    {
        keyboardControls.Disable();
    }
    void Start()
    {

    }


    private void DestroyObject()
    {
        Destroy(gameObject);
    }

  
}
