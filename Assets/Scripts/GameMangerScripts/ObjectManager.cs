using UnityEngine;
using System.Collections;

public class ObjectManager : MonoBehaviour 
{
	public GameObject[] enemies;
	public GameObject[] spawnPoints;

	void Update()
	{
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
	}
}
