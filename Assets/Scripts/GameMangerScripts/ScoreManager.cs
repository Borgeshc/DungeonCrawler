using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
	public Text gameTimer;
	public Text eliminations;
	public int enemiesKilled;
	public int timer;
	void Update () 
	{
		timer = (int)Time.time;
		gameTimer.text = "Time Player: " + timer;
		eliminations.text = "Eliminations: " + enemiesKilled;
	}

	public void EnemyDied()
	{
		enemiesKilled++;
	}
}
