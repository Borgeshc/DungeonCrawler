using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour 
{
	public GameObject[] playerOneEnemies;
    public GameObject[] playerTwoEnemies;

	public GameObject[] playerOneSpawnPoints;
    public GameObject[] playerTwoSpawnPoints;

    void Update()
	{
        playerOneEnemies = GameObject.FindGameObjectsWithTag ("PlayerOneUnit");
        playerTwoEnemies = GameObject.FindGameObjectsWithTag("PlayerTwoUnit");
    }
}
