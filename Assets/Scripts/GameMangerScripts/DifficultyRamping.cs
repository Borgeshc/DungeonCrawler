using UnityEngine;
using System.Collections;

public class DifficultyRamping : MonoBehaviour 
{
	public int increaseDifficultyAfter;

	SpawnManager spawnManager;
	ObjectManager objectManager;
	ScoreManager scoreManager;
	bool increment;
	// Use this for initialization
	void Start () 
	{
		spawnManager = GetComponent<SpawnManager> ();
		objectManager = GetComponent<ObjectManager> ();
		scoreManager = GetComponent<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
			if (scoreManager.timer % increaseDifficultyAfter == 0 && scoreManager.timer != 0) 
			{	
				if(!increment)
				{
					spawnManager.enemiesActive++;
					StartCoroutine(Increment());
				}
			}
	}

	IEnumerator Increment()
	{
		increment = true;
		yield return new WaitForSeconds (1);
		increment = false;
	}
}
