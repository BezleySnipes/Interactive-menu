using UnityEngine;
using System.Collections;

public class colorChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		public static Color black;
	currentColor = color.black;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R))
		{
            currentColor = color.blue;
		}
		
		//color = gameObject.GetComponent<Renderer>().material.color ;
	}
}
