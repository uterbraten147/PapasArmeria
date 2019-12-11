using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmsCreator : MonoBehaviour
{
	[Header("Arma Final")]
	public GameObject FinalWeapon;
	
	public List<ElementosArma> elementos = new List<ElementosArma>();
	
	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("BodyPart"))
		{
			other.transform.SetParent(FinalWeapon.transform,false);
			//other.GetComponent<DragObject>().enabled =false;
			elementos.Add( new ElementosArma(other.name));
		}
		if(other.gameObject.CompareTag("Cargador"))
		{
			other.GetComponent<DragObject>().enabled =false;
			elementos.Add( new ElementosArma(other.name));
		}
		if(other.gameObject.CompareTag("Mira"))
		{
			other.GetComponent<DragObject>().enabled =false;
			elementos.Add( new ElementosArma(other.name));
		}
	}
}
