using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {
	public AudioClip level2Music;
	private AudioSource source;
	// Use this for initialization
	void Awake () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level)
	{
		if (level == 2 || level == 1 || level == 3)
		{
			source.clip = level2Music;
			source.Play ();
		}
		if (level == 0)
		{
			source.Stop ();
		}
	}
}
