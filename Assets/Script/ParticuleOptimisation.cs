using UnityEngine;
using System.Collections;

public class ParticuleOptimisation : MonoBehaviour {
	
	public int distanceshow = 150;
	GameObject player;

	void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update () 
	{
		if(Vector3.Distance(player.transform.position, gameObject.transform.position) < distanceshow)
		{
			//print ("Activé");
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
		}
		else
		{
			//print ("Désactivé");
			gameObject.GetComponent<ParticleSystem>().enableEmission = false;
		}
	}
	
}
