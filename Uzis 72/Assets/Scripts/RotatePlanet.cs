using System.Collections;
using UnityEngine;

public class RotatePlanet: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 360.0f / 100.0f * Time.deltaTime, 0.0f);
    }
}
