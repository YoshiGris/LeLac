using UnityEngine;
using System.Collections;

public class MenuFunction : MonoBehaviour {

	public void Exit(){ print ("Et là... plus de mayo !"); Application.Quit(); }

	void Update()
	{
		if(Input.GetKeyDown("escape"))
		{
			print ("Et là... plus de mayo !");
			Cursor.visible = true;
			Application.LoadLevel("menu");
		}
	}
}
