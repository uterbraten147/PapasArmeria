using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregaArma : MonoBehaviour
{
	public GameObject posEntrega;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		//GetComponent<DragObject>().enabled = false;
	}
	public void ActivoMov()
	{
		transform.position = new Vector3(posEntrega.transform.position.x,posEntrega.transform.position.y,posEntrega.transform.position.z);
		transform.rotation = (posEntrega.transform.rotation);
		//GetComponent<DragObject>().enabled = true;
	} 
}
