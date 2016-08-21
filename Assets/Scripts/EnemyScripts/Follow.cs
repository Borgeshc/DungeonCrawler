using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour 
{
	public int minSpeed;
	public int maxSpeed;
	float speed;
	GameObject target;
    NavMeshAgent agent;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Player");
		speed = Random.Range (minSpeed, maxSpeed);
        agent = GetComponent<NavMeshAgent>();
	}
	void Update () 
	{
		transform.LookAt (target.transform);
        agent.SetDestination(target.transform.position);
		//transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}
	public void UpdateSpeed()
	{
		speed = Random.Range (minSpeed, maxSpeed);
	}
}
