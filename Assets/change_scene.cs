using UnityEngine;
using System.Collections;

public class change_scene : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other)
	{

		Debug.Log("I hit something: " + other.gameObject);
		if (other.gameObject.tag == "Player")
		{
			StartCoroutine("LoadNextLevel");
		}
	}

	IEnumerator LoadNextLevel() {
		yield return new WaitForSeconds(0.5f);
		Application.LoadLevel (1);
	}

}
