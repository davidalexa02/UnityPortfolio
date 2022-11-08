using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textscorep1;
    public Text textscoreai;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textscorep1.text = "" + GameManager.scorep1;
        textscoreai.text = "" + GameManager.scoreai;
    }
}
