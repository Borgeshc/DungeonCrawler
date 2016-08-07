using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour 
{
	public int baseHealth;
	public int currentHealth;
	public int lives;
	public Transform spawnPoint;

	// Use this for initialization
	void Start () 
	{
		currentHealth = baseHealth;
	}

	void Update () 
	{
		if (currentHealth <= 0 && lives > 0) 
		{
			Respawn ();
		} 
		if(currentHealth <= -1 && lives <= 0)
		{
			Died ();
		}
	}

	void Respawn()
	{
		lives--;

		transform.position = spawnPoint.transform.position;
		currentHealth = baseHealth;
	}

	void Died()
	{
		print ("You should be dead");
		Destroy (this.transform.gameObject);
		//Application.LoadLevel("LoseScreen");
	}
	public void TookDamage()
	{
		currentHealth--;
	}
}
