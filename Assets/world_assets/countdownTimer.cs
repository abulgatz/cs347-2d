using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour 
{
	public int level_index = 2;
	public Text timerText;
	public static float timer = 15.0f;

	// Use this for initialization
	void Start () 
	{
		timerText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		timerText.text = "Remaining Time: " + timer.ToString ("0");
		if (timer <= 0) 
		{
			Application.LoadLevel(level_index);
		}
    }
}
