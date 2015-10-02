using UnityEngine;
using System.Collections;

public class change_scene : MonoBehaviour {
	void OnCollisionEnter(Collision2D col)
	{
		if (col.gameObject.tag == "crack") 
		{
			Application.LoadLevel("second_stage.unity");
		}
	}
}
