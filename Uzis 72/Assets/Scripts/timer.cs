using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private float timeValue = 120;
    public Text Timer;
    public static bool isShowing=true;
    public GameObject Finish;
    public GameObject HUD;

    private void Start()
    {
        Finish.SetActive(false);
        HUD.SetActive(isShowing);
    }
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            Time.timeScale = 0;

            HUD.SetActive(false);
            Finish.SetActive(isShowing);
        }
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        Timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}