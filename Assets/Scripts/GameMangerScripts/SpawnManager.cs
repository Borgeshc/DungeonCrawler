using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject spawnable;
	ObjectManager objectManager;
	public int enemiesActive;

	void Start()
	{
		objectManager = GetComponent<ObjectManager> ();
	}
	void Update () 
	{
		if (GetComponent<ObjectManager> ().enemies.Length < enemiesActive) 
		{
			Spawn();
		}
	}

	void Spawn()
	{
		Instantiate(spawnable, 
		            objectManager.spawnPoints[Random.Range(0,objectManager.spawnPoints.Length)].transform.position, 
		            objectManager.spawnPoints[Random.Range(0,objectManager.spawnPoints.Length)].transform.rotation);
	}
}
