using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public static bool isShowing = true;
    public GameObject CanvasPause;
    // Start is called before the first frame update
    public void Start()
    {
        CanvasPause.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            CanvasPause.SetActive(isShowing);
        }
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // Update is called once per frame
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void GoBack()
    {
        CanvasPause.SetActive(false);
        Time.timeScale = 1;
    }
    public void GoBackToMain()
    {
        GameManager.scoreai = 0;
        GameManager.scorep1 = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
