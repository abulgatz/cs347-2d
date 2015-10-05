using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour 
{
	public Text timerText = "Remaining Time";
	public float timer = 15.0f;
	public SpriteRenderer item_sr;
	public PolygonCollider2D item_pc;

	// Use this for initialization
	void Start () 
	{
		timerText = GetComponent<Text> ();
		item_sr = GetComponent<SpriteRenderer> ();
		item_pc = GetComponent<PolygonCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		timerText.text = "Remaining Time: " + timer.ToString ();
    }

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			item_sr.enabled = false;
			item_pc.enabled = false;
			timer += 10.0f;
        }
    }
}
