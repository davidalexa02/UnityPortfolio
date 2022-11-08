using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public GameObject CountdownCanvas;
    public GameObject three;
    public GameObject two;
    public GameObject one;
    public static bool isShowing = true;
    private int Timerr;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        CountdownCanvas.SetActive(isShowing);
        three.SetActive(false);
        two.SetActive(false);
        one.SetActive(false);
        CountdownYes();
        Timerr = -800;
    }

    void Update()
    {
        CountdownYes();
    }
    // Update is called once per frame
    void CountdownYes()
    {
        Timerr++;
        if(Timerr==-600)
        {
            three.SetActive(isShowing);
        }
        if (Timerr == -400)
        {
            three.SetActive(false);
            two.SetActive(isShowing);
        }
        if (Timerr == -200)
        {
            two.SetActive(false);
            one.SetActive(isShowing);
        }
        if (Timerr == 0)
        {
            one.SetActive(false);
            CountdownCanvas.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
