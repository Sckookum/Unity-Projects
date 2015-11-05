using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timeRemaining = 10;


	void Start () 
	{
	
	}

	void OnCollisionEnter(Collision collision)
	{

	}

	void Update () {
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI()
	{
		if(timeRemaining > 0 )
		{
			GUI.Label(new Rect(100, 100, 200, 100), "Time Remaining : " + timeRemaining);
				
		}
		if (timeRemaining < -1)
		{
			Application.LoadLevel (0);
		}
		if ( timeRemaining > -1 && timeRemaining < 0)
		{
			GUI.Label(new Rect(100, 100, 200, 100), "Time's up!");
		}
	}
}
