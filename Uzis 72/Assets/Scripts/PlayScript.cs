using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public static bool isShowing = true;
    public GameObject Canvas;
    public GameObject CanvasPlay;
    public GameObject CanvasSettings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click1P()
    {
        SceneManager.LoadScene("UzisCPU");
    }
    public void Click2P()
    {
        SceneManager.LoadScene(2);
    }
    public void GoBack()
    {
        Canvas.SetActive(isShowing);
        CanvasPlay.SetActive(false);
        CanvasSettings.SetActive(false);
    }
}
