using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour 
{
    public string targetTag;

    void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == targetTag) 
		{
			GetComponent<Follow>().enabled = false;
			other.transform.GetComponent<Health>().TookDamage();
		}
	}
	void OnCollisionExit(Collision other)
	{
		if (other.transform.tag == targetTag) 
		{
			GetComponent<Follow>().enabled = true;
		}
	}
}
