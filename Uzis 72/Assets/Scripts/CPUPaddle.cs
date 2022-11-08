using UnityEngine;
using System.Collections;
public class CPUPaddle : MonoBehaviour
{
    public float speed = 3.0f;
    private const float leftLimit = -2.9f;
    private const float rightLimit = 2.9f;
    public GameObject ball;
    // Use this for initialization
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float ballPos = ball.transform.position.x;
        transform.Translate(Time.deltaTime * speed, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(ballPos, leftLimit, rightLimit),transform.position.y,transform.position.z);
    }
}
