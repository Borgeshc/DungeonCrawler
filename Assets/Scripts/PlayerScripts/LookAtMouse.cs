using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour 
{
	void Start()
	{
		Cursor.visible = false;
	}
	
	void Update() 
	{
			RotateToMouse ();
	}
	
	void RotateToMouse() 
	{
		Vector3 v3T = Input.mousePosition;
		v3T.z = Mathf.Abs(Camera.main.transform.position.y - transform.position.y);
		v3T = Camera.main.ScreenToWorldPoint(v3T);
		transform.LookAt(v3T);
	}
}
