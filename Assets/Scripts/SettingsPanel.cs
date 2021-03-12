using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private bool isDisplayed;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            isDisplayed = !isDisplayed;
        }

        if (isDisplayed)
        { ActivateMenu(); }

        else
        { DeactivateMenu(); }
    }

    void ActivateMenu()
    { settingsPanel.SetActive(true); }

    void DeactivateMenu()
    { settingsPanel.SetActive(false); }
}
