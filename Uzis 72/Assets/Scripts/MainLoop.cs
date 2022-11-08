using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainLoop : MonoBehaviour
{

	public GameObject RandomBlock;
	private bool enableBlocks = true;
	public static bool BlockIsShowing;
	private int spawntime;
	// Use this for initialization
	void Start()
	{
		StartCoroutine(BlocksAppear());
	}

	// Update is called once per frame
	void Update()
	{
	}

	IEnumerator BlocksAppear()
	{
		// Initial delay
		yield return new WaitForSeconds(Random.Range(8.0f, 15.0f));

		while (enableBlocks)
		{
            _ = Instantiate(RandomBlock);
			BlockIsShowing = true;
			RandomBlock.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), 0, Random.Range(-4.5f, 4.5f));
			yield return new WaitForSeconds(Random.Range(8.0f, 15.0f));
		}

	}
}