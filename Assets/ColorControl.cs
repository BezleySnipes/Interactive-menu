using UnityEngine;
using System.Collections;

public class ColorControl : MonoBehaviour {

	public GameObject Obj1;
	//public Color red = Color.red;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update(){
    if (Input.GetMouseButtonDown(0)){ 
     	Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
     	RaycastHit hit;

    if (Physics.Raycast(ray, out hit))
    {
       Obj1 = hit.collider.gameObject;
    }
   }
 }

	public void Red()
	{
		Obj1.GetComponent<Renderer>().material.color = Color.red;
	}
	public void Yellow()
	{
		Obj1.GetComponent<Renderer>().material.color = Color.yellow;
	}
	public void Blue()
	{
		Obj1.GetComponent<Renderer>().material.color = Color.blue;
	}
	public void Green()
	{
		Obj1.GetComponent<Renderer>().material.color = Color.green;
	}
}
