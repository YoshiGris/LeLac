using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {
	public Camera newcamera;
	public GameObject destroyui;public GameObject destroyuib;public GameObject destroyuic;public GameObject destroyuid;
	
	void Start () 
	{
		Cursor.visible = false;
		newcamera.enabled = true;
		Destroy(destroyui);Destroy(destroyuib);Destroy(destroyuic);Destroy(destroyuid);
		Destroy(this.gameObject);
	}

}