using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public float cameraSpring = 3.0f;
	GameObject player;

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () 
	{
		Vector3 cameraOffset = player.transform.position;
		
		cameraOffset.y = transform.position.y;
		transform.position = Vector3.Lerp (transform.position, cameraOffset, Time.deltaTime * cameraSpring);
	}
}
