/*
 * Footstep script
 * Developped by Yoshi_Gris - Survivaliste Project
 * 04/2015
*/
using UnityEngine;
using System.Collections;

public class FootstepSound : MonoBehaviour {

	public AudioClip[] footstep;
	public AudioClip jumpsound;
	public int maxstep;
	int savemax;
	int maxdivise;
	AudioSource audios;
	int step = 0;
	bool jumpa = false;

	void Start(){audios = GetComponent<AudioSource>(); savemax = maxstep; maxdivise = maxstep / 2;}

	void FixedUpdate () 
	{

		if(Input.GetKeyDown("space")) //Son jump
		{
			jumpa = true;
		}

		if(Input.GetKeyDown(KeyCode.LeftShift)) //Son courir
		{
			maxstep = maxdivise;
		}

		if(Input.GetKeyUp(KeyCode.LeftShift)) //Son courir stop
		{
			maxstep = savemax;
		}

	}

	void OnCollisionStay(Collision collisionInfo) 
	{

		if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) //Son marche
		{
			
			if(step > maxstep)
			{
				audios.PlayOneShot(footstep[Random.Range(0, footstep.Length)], 0.6F);
				step = 0;
			}
			else
			{
				step++;
			}
			
		}

	}

	void OnCollisionEnter(Collision collision) 
	{
		if(/*collision.relativeVelocity.magnitude > 10 &&*/ jumpa)
		{
			audios.PlayOneShot(jumpsound, 0.6F);
			jumpa = false;
		}
	}
}