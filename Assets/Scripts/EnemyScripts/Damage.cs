using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour 
{
	void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Player") 
		{
			GetComponent<Follow>().enabled = false;
			other.transform.GetComponent<Health>().TookDamage();
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.transform.tag == "Player") 
		{
			GetComponent<Follow>().enabled = true;
		}
	}
}
