using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public static bool isShowing = true;
    public GameObject Canvas;
    public GameObject CanvasPlay;
    public GameObject CanvasSettings;
    // Start is called before the first frame update
    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // Update is called once per frame
    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void GoBack()
    {
        Canvas.SetActive(isShowing);
        CanvasPlay.SetActive(false);
        CanvasSettings.SetActive(false);
    }
}
