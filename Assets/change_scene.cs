using UnityEngine;
using System.Collections;

public class change_scene : MonoBehaviour 
{
	void OnTriggerEnter2D (Collider2D other)
	{
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
