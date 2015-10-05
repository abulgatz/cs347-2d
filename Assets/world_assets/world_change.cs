using UnityEngine;
using System.Collections;

public class world_change : MonoBehaviour 
{
	public SpriteRenderer sr;
	public PolygonCollider2D pc;
	public Color color1 = Color.blue;
	public Color color2 = Color.red;
	// Use this for initialization
	void Start () 
	{
		sr = GetComponent<SpriteRenderer> ();
		pc = GetComponent<PolygonCollider2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.C) && sr.enabled == true && pc.enabled == true) 
		{
			sr.enabled = false;
			pc.enabled = false;
			Camera.main.backgroundColor = color1;
		} 
		else if (Input.GetKeyDown (KeyCode.C) && sr.enabled == false && pc.enabled == false) 
		{
			sr.enabled = true;
			pc.enabled = true;
			Camera.main.backgroundColor = color2;
		}
	}
}
