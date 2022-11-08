using UnityEngine;
using System.Collections;
public class RandomBlock : MonoBehaviour
{
    public GameObject spark;
    public static bool BlockIsShowing;
    private int Spawntime;
    public MainLoop MainLoop;
    //private float Decision;
    //public GameObject CPU;
    //public GameObject Player1;
    //private Vector3 BallChangeBigger;
    //private Vector3 BallChangeSmaller;
    //private Vector3 OriginalState;
    //public GameObject Ball;
    //private int TimeEffect;
    // Use this for initialization
    void Start()
    {
        //TimeEffect = 0;
        //BallChangeBigger = new Vector3(1.2f, 1.2f, 1.2f);
        //BallChangeSmaller = new Vector3(0.2f, 0.2f, 0.2f);
    }
    // Update is called once per frame
    void Update()
    {
        Spawntime++;
        if (Spawntime == 800)
        {
            Destroy(gameObject);
            Spawntime = 0;
            MainLoop.BlockIsShowing = false;
        }
        //Decision = Random.Range(0.0f, 4.9f);
    }
    void OnCollisionEnter(Collision collision)
    {
        Destroy(Instantiate(spark, transform.position, Quaternion.identity), 3.0f);
        Destroy(gameObject);
    }
}