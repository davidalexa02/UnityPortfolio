using UnityEngine;
using System.Collections;
public class LevelObject : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        if (LevelManager.numInitialBlocks == 0)
            Application.LoadLevel(Application.loadedLevel);
    }
}