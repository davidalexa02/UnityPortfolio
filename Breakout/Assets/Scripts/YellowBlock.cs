using UnityEngine;
using System.Collections;
public class YellowBlock : MonoBehaviour
{
    public GameObject spark;
    private int touches = 2;
    // Use this for initialization
    void Start()
    {
        LevelManager.numInitialBlocks++;
    }
    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        touches--;
        if (touches == 0)
        {
            Instantiate(spark, transform.position, Quaternion.identity);
            Destroy(gameObject);
            LevelManager.numInitialBlocks--;
        }
    }
}