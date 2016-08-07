using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour 
{
	public int minSpeed;
	public int maxSpeed;
	float speed;
	GameObject target;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Player");
		speed = Random.Range (minSpeed, maxSpeed);
	}
	void Update () 
	{
		transform.LookAt (target.transform);
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
	public void UpdateSpeed()
	{
		speed = Random.Range (minSpeed, maxSpeed);
	}
}
