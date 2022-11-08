using UnityEngine;
using System.Collections;
public class RedBlock : MonoBehaviour
{
    public GameObject Explosion;
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
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        LevelManager.numInitialBlocks--;
    }
}