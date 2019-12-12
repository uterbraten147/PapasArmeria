using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerArmas : MonoBehaviour
{
	[Header("Cuerpos De Arma")]
	public GameObject arma1;
	public GameObject arma2;
	public GameObject arma3;
	public GameObject arma4;
	
	[Header("Botones De Opciones Accesorios")]
	public GameObject caja1;
	public GameObject caja2;
	public GameObject caja3;
	public GameObject botonAK1;
	public GameObject botonAK2;
	public GameObject botonAK3;
	
	[Header("Accesorios AK")]
	public GameObject ac1;
	public GameObject ac3;
	
	[Header("Posiciones Accesorios")]
	public GameObject posPrevAccesorio1;
	public GameObject posPrevAccesorio2;
	public GameObject posPrevAccesorio3;
	public GameObject posArm1;
	public GameObject posArm2;
	public GameObject posArm3;
	public GameObject posArm4;
	
	
	public void SelectorArmas1()
	{
		Instantiate(arma1,posArm1.transform.position, posArm1.transform.rotation);
		caja1.SetActive(true);
		caja3.SetActive(true);
		botonAK1.SetActive(true);
		botonAK2.SetActive(true);
	}
	
	public void Boton1AK()
	{
		Instantiate(ac1,posPrevAccesorio1.transform.position,posPrevAccesorio1.transform.rotation);
	}
	
	public void Boton3AK()
	{
		Instantiate(ac3,posPrevAccesorio3.transform.position,posPrevAccesorio3.transform.rotation);
	} 
}
