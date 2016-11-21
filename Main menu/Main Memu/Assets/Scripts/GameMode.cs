using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameMode : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas EnterCanvas;
    public Canvas SingleCanvas;
    public Canvas MultiCanvas;

    void Awake()
    {
        EnterCanvas.enabled = true;
        MainCanvas.enabled = true;
        SingleCanvas.enabled = false;
        MultiCanvas.enabled = false;
    }
    public void SingleOn()
    {
        EnterCanvas.enabled = false;
        MainCanvas.enabled = true;
        SingleCanvas.enabled = true;
        MultiCanvas.enabled = false;
    }
    public void MultiOn()
    {
        EnterCanvas.enabled = false;
        MainCanvas.enabled = true;
        SingleCanvas.enabled = false;
        MultiCanvas.enabled = true;
    }
    public void BackOn()
    {
        EnterCanvas.enabled = true;
        MainCanvas.enabled = true;
        SingleCanvas.enabled = false;
        MultiCanvas.enabled = false;
    }
}
