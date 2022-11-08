using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public static bool isShowing = true;
    public GameObject Canvas;
    public GameObject CanvasPlay;
    public GameObject CanvasSettings;
    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(isShowing);
        CanvasPlay.SetActive(false);
        CanvasSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickPlay()
    {
        Canvas.SetActive(false);
        CanvasPlay.SetActive(isShowing);
        CanvasSettings.SetActive(false);
    }
    public void ClickSettings()
    {
        Canvas.SetActive(false);
        CanvasPlay.SetActive(false);
        CanvasSettings.SetActive(isShowing);
    }
}
