using UnityEngine;
using System.Collections;

public class LoadMainMusic : MonoBehaviour {
	public AudioClip mainMusic;
	private AudioSource source;

	void Awake () {
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level)
	{
		if (level == 0)
		{
			source.clip = mainMusic;
			source.Play ();
		}

	}
}
