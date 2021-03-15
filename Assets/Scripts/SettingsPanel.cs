using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    private GeneralControls keyboardControls;
    [SerializeField] private GameObject settingsPanel;
    public bool isDisplayed;
    
    private void Awake()
    {
        isDisplayed = true;
        keyboardControls = new GeneralControls();
    }

    private void OnEnable()
    {
        keyboardControls.Enable();
    }

    private void OnDisable()
    {
        keyboardControls.Disable();
    }

    // Update is called once per frame
    private void Update()
    {
        if (isDisplayed == false) { keyboardControls.Keyboard.Settings.performed += _ => ActivateMenu(); }

        else { keyboardControls.Keyboard.Settings.performed += _ => DeactivateMenu(); }
        /*if (Input.GetKeyDown(KeyCode.F1))
        {
            isDisplayed = !isDisplayed;
        }

        if (isDisplayed)
        { ActivateMenu(); }

        else
        { DeactivateMenu(); } */
    }

    void ActivateMenu()
    { settingsPanel.SetActive(true); isDisplayed = true; }

    void DeactivateMenu()
    { settingsPanel.SetActive(false); isDisplayed = false; }
}
