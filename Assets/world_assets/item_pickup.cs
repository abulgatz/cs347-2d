using UnityEngine;
using System.Collections;

public class item_pickup : MonoBehaviour 
{
	public SpriteRenderer item_sr;
	public PolygonCollider2D item_pc;

	// Use this for initialization
	void Start () 
	{
		item_sr = GetComponent<SpriteRenderer> ();
		item_pc = GetComponent<PolygonCollider2D> ();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			item_sr.enabled = false;
			item_pc.enabled = false;
			countdownTimer.timer+=10.0f;
		}
	}
}
