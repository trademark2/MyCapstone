using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Setting : MonoBehaviour {

    public Canvas MainMenuCanvas;
    public Canvas SettingCanvas;

    void Awake()
    {
        SettingCanvas.enabled = false;
    }
    public void SettingOn()
    {
        SettingCanvas.enabled = true;
        MainMenuCanvas.enabled = false;
    }
    public void MenuOn()
    {
        SettingCanvas.enabled = false;
        MainMenuCanvas.enabled = true;
    }
   
}
