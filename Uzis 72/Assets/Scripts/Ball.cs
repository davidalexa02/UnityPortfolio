using UnityEngine;
using System.Collections;
public class Ball : MonoBehaviour
{
    private const float speedIncrement = 0.3f;
    private const float speedIncrementRate = 7.0f;
    private float Decision;
    public static bool isShowing = true;
    public GameObject CPU;
    public GameObject Player1;
    private Vector3 BallChangeBigger = new Vector3(1.2f, 1.2f, 1.2f);
    private Vector3 BallChangeSmaller = new Vector3(0.2f, 0.2f, 0.2f);
    private Vector3 OriginalState;
    private int TimeEffect=0;
    // Use this for initialization
    void Start()
    {
        //TimeEffect = 0;
        //BallChangeBigger = new Vector3(1.2f, 1.2f, 1.2f);
        //BallChangeSmaller = new Vector3(0.2f, 0.2f, 0.2f);
        RestartBall();
        StartCoroutine(IncreaseSpeed());
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Die")
        {
            RestartBall();
            GameManager.scoreai++;
        }
        if (collision.gameObject.tag == "DieCPU")
        {
            RestartBall();
            GameManager.scorep1++;
        }
    }
    void RestartBall()
    {
        transform.position = new Vector3(0.0f, 0.25f, 0.0f);
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        Decision = Random.Range(0.0f, 10.0f);
        if(Decision>=0.0f && Decision<2.5f)
        {
            GetComponent<Rigidbody>().AddForce(-Random.Range(3.5f, 4.0f), 0.0f, -Random.Range(3.5f, 4.0f), ForceMode.Impulse);
        }
        else if(Decision >= 2.5f && Decision < 5.0f)
        {
            GetComponent<Rigidbody>().AddForce(Random.Range(3.5f, 4.0f), 0.0f, -Random.Range(3.5f, 4.0f), ForceMode.Impulse);
        }
        else if (Decision >= 5.0f && Decision < 7.5f)
        {
            GetComponent<Rigidbody>().AddForce(-Random.Range(3.5f, 4.0f), 0.0f, Random.Range(3.5f, 4.0f), ForceMode.Impulse);
        }
        else if (Decision >= 7.5f && Decision <= 10.0f)
        {
            GetComponent<Rigidbody>().AddForce(Random.Range(3.5f, 4.0f), 0.0f, Random.Range(3.5f, 4.0f), ForceMode.Impulse);
        }
    }
    IEnumerator IncreaseSpeed()
    {
        Decision = Random.Range(0.0f, 5.0f);
        while (true)
        {
            GetComponent<Rigidbody>().AddForce(GetComponent<Rigidbody>().velocity.normalized * speedIncrement, ForceMode.Impulse);
            yield return new WaitForSeconds(speedIncrementRate);
            if (Decision >= 0.0f && Decision < 2.5f)
            {
                //Ball gets bigger
                OriginalState = transform.localScale;
                transform.localScale = BallChangeBigger;
                while (TimeEffect != 1600)
                {
                    TimeEffect++;
                }
                TimeEffect = 0;
                transform.localScale = OriginalState;
            }
            else if (Decision >= 2.5f && Decision <= 5.0f)
            {
                //Ball gets smaller
                OriginalState = transform.localScale;
                transform.localScale = BallChangeSmaller;
                while (TimeEffect != 1600)
                {
                    TimeEffect++;
                }
                TimeEffect = 0;
                transform.localScale = OriginalState;
            }
        }
    }
}