using UnityEngine;
using System.Collections;

public class healthBlender : MonoBehaviour {
	Animator anim;
	public static float health = 100f;
	float maxHealth = 100f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.J)) 
		{
			health += 15;
		}

	if (Input.GetKeyDown (KeyCode.K)) 
		{
			health -= 15;
		}

		if (health >= maxHealth) 
		{
			health = maxHealth;
		}
		if (health < 0)
		{
			health = 0;
		}
		anim.SetFloat ("HealthBlend", health);
	}
	//use to call in other scripts.
	/*if()
	{
		healthBlender.health -= 10;
	}*/
}
