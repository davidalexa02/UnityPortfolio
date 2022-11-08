using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    public Text Winnertext;
    public Text Timer;
    public static bool isShowing = true;
    public GameObject Finish;
    public GameObject HUD;
    public GameObject ball;
    //public MainLoop MainLoop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.scoreai < GameManager.scorep1)
        {
            Winnertext.text = "P1 WINS!";
        }
        if (GameManager.scoreai > GameManager.scorep1)
        {
            Winnertext.text = "CPU/P2 WINS!";
        }
        if (GameManager.scoreai == GameManager.scorep1)
        {
            Winnertext.text = "IT'S A DRAW!";
        }
    }

    public void ClickPlayAgain()
    {
        SceneManager.LoadScene(1);
        ball.transform.position = new Vector3(0.0f, 0.25f, 0.0f);
        GameManager.scoreai = 0;
        GameManager.scorep1 = 0;
        Time.timeScale = 1;
        HUD.SetActive(isShowing);
        Finish.SetActive(false);
    }
    public void ClickMainMenu()
    {
        GameManager.scoreai = 0;
        GameManager.scorep1 = 0;
        SceneManager.LoadScene("MainMenu1");
        HUD.SetActive(isShowing);
        Finish.SetActive(false);
        Time.timeScale = 1;
    }
}
