using UnityEngine;
using System.Collections;
public class Paddle : MonoBehaviour
{
    public float speed;
    private const float leftLimit = -4.5f;
    private const float rightLimit = 4.5f;
    //float MovementX;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //MovementX = Input.GetAxis("Horizontal");
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), transform.position.y, transform.position.z);
    }
}