﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour 
{
	public Text timerText;
	public float timer = 15.0f;


	// Use this for initialization
	void Start () 
	{
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		timerText.text = "Remaining Time: " + timer.ToString ();
		if (timer <= 0) 
		{
			Application.LoadLevel(2);
		}
    }
}
