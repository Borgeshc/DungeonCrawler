using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour 
{
	public float speed = 10.0F;

	void Update() 
	{
		float vertical = Input.GetAxis("Vertical") * speed;
		float horizontal = Input.GetAxis("Horizontal") * speed;
		vertical *= Time.deltaTime;
		horizontal *= Time.deltaTime;
		transform.Translate(0, 0, vertical);
		transform.Translate(horizontal, 0, 0);
	}
}
