using UnityEngine;
using System.Collections;

public class change_scene : MonoBehaviour 
{
	void OnCollisionEnter2D (Collision2D Collider)
	{
		if (Collider.gameObject.tag == "Player")
		{
			Application.LoadLevel (1);
		}
	}
}
