using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdasd : MonoBehaviour
{
	[Header("Areas de Drop")]
	public GameObject posCargador;
	public GameObject posMira;
	[Header("Arma Final")]
	public GameObject FinalWeapon;
	
	// OnTriggerStay is called once per frame for every Collider other that is touching the trigger.
	protected void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Cargador"))
		{
			Rigidbody rg = other.GetComponent<Rigidbody>();
			StartCoroutine(Espera(other,rg));
		}
		if(other.gameObject.CompareTag("Mira"))
		{
			Rigidbody rgi = other.GetComponent<Rigidbody>();
			StartCoroutine(EsperaMira(other,rgi));
		}
	}
	
	IEnumerator Espera(Collider accesorio,Rigidbody rg)
	{
		yield return new WaitForSeconds(1.0f);
		accesorio.transform.SetParent(FinalWeapon.transform,false);
		accesorio.transform.position = new Vector3(posCargador.transform.position.x,posCargador.transform.position.y,posCargador.transform.position.z);
		accesorio.transform.rotation = posCargador.transform.rotation;
		rg.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
	}
	IEnumerator EsperaMira(Collider acce,Rigidbody rgi)
	{
		yield return new WaitForSeconds(1.0f);
		acce.transform.SetParent(FinalWeapon.transform,false);
		acce.transform.rotation = posMira.transform.rotation;
		acce.transform.position = new Vector3(posMira.transform.position.x,posMira.transform.position.y,posMira.transform.position.z);
		rgi.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
	}
}
