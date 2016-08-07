using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour 
{
	public int baseHealth;
	public int currentHealth;
	GameObject gameManager;
	void Start () 
	{
		gameManager = GameObject.FindGameObjectWithTag ("GameManager");
		currentHealth = baseHealth;
	}

	public void TookDamage(int damagedTaken)
	{
		currentHealth = currentHealth - damagedTaken;
		if (currentHealth <= 0) 
		{
			gameManager.GetComponent<ScoreManager>().EnemyDied();
			Destroy(this.gameObject);
		}
	}
}
