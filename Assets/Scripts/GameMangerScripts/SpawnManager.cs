using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{
	public GameObject playerOneUnits;
    public GameObject playerTwoUnits;
	ObjectManager objectManager;
	public int enemiesActive;

	void Start()
	{
		objectManager = GetComponent<ObjectManager> ();
	}
	void Update () 
	{
		if (GetComponent<ObjectManager> ().playerOneEnemies.Length < enemiesActive) 
		{
			Spawn();
		}
        if (GetComponent<ObjectManager>().playerTwoEnemies.Length < enemiesActive)
        {
            Spawn();
        }
	}

	void Spawn()
	{
		Instantiate(playerOneUnits, 
		            objectManager.playerOneSpawnPoints[Random.Range(0,objectManager.playerOneSpawnPoints.Length)].transform.position, 
		            objectManager.playerOneSpawnPoints[Random.Range(0,objectManager.playerOneSpawnPoints.Length)].transform.rotation);

        Instantiate(playerTwoUnits,
                    objectManager.playerTwoSpawnPoints[Random.Range(0, objectManager.playerTwoSpawnPoints.Length)].transform.position,
                    objectManager.playerTwoSpawnPoints[Random.Range(0, objectManager.playerTwoSpawnPoints.Length)].transform.rotation);
    }
}
