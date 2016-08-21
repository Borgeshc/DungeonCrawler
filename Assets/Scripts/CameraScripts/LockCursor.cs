using UnityEngine;
using System.Collections;

public class LockCursor : MonoBehaviour
{
    public Texture2D cursor;

	void Start ()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.Auto);
       // Cursor.visible = false;
	}
	
	void Update () {
	
	}
}
