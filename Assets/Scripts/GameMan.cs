using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;


public class GameMan : MonoBehaviour
{
	
	public GameObject  PanelOpciones, PanelArma1, PanelArma2, PanelArma3, PanelArma4,
		PanelTienda, PanelLavadoras, PanelProbar, BTNEntregar, BTNTirar;
	public CinemachineVirtualCamera VCamMesa, VCamOptions, VCamArmaTest, VCamShop, VCamLavadoras;
	float tiempo = 2.0f, tiempoCarga;
	public 	Image BarraCarga ;
	public  Text mensajeArma;


    // Start is called before the first frame update
    void Start()
	{
		PanelTienda.SetActive(true);
		
		PanelOpciones.SetActive(false);
		
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);
		
		PanelLavadoras.SetActive(false);
		PanelProbar.SetActive(false);

		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 10;
		VCamLavadoras.Priority= 0;
		
		mensajeArma.text = "";
		
		BTNEntregar.SetActive(false);
		BTNTirar.SetActive(false);
		
		
	}
    
	public void FuncProbarArma()
	{
		
		StartCoroutine(probadorDeArma());
		
	}

   
    
    
	public void SettingsBTN()
	{
	
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 10;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 0;
		VCamLavadoras.Priority= 0;
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);
		PanelTienda.SetActive(false);
		
		StartCoroutine(esperarCamara(tiempo,0));
		
	}
	
	
	
	public void ActPanelA1()
	{
		PanelOpciones.SetActive(false);
		
		VCamMesa.Priority = 10;
		VCamOptions.Priority= 0;	
		
		StartCoroutine(esperarCamara(tiempo,1));

	}
	
	public void ActPanelA2()
	{
		PanelOpciones.SetActive(false);
		
		VCamMesa.Priority = 10;
		VCamOptions.Priority= 0;
		StartCoroutine(esperarCamara(tiempo,2));
	}
	
	public void ActPanelA3()
	{
		PanelOpciones.SetActive(false);
		
		VCamMesa.Priority = 10;
		VCamOptions.Priority= 0;
		StartCoroutine(esperarCamara(tiempo,3));
		
		
	}
	
	public void ActPanelA4()
	{
		PanelOpciones.SetActive(false);

		VCamMesa.Priority = 10;
		VCamOptions.Priority= 0;
		
		StartCoroutine(esperarCamara(tiempo,4));
	}
	
	public void probarArma()
	{
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=10;
		VCamShop.Priority = 0;
		VCamLavadoras.Priority= 0;
		
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);
		PanelOpciones.SetActive(false);
		PanelLavadoras.SetActive(false);
		StartCoroutine(esperarCamara(tiempo,7));
	}
	
	public void LavadoraBTN()
	{
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 0;
		VCamLavadoras.Priority= 10;
		
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);
		PanelOpciones.SetActive(false);
		
		StartCoroutine(esperarCamara(tiempo,6));
	}
	
	public void DarArma()
	{
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 10;
		
		PanelProbar.SetActive(false);
		
		mensajeArma.text="";
		
		//Aumentar score del player
		
		BTNEntregar.SetActive(false);
		BTNTirar.SetActive(false);
		
		StartCoroutine(esperarCamara(tiempo, 5));
	}
	
	public void QuitarArma()
	{
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 10;
		
		PanelProbar.SetActive(false);
		
		mensajeArma.text="";
		
		//Decrementar score del player
		
		BTNEntregar.SetActive(false);
		BTNTirar.SetActive(false);
		
		StartCoroutine(esperarCamara(tiempo, 5));
	}
	
	
	
	
	
	public void verTienda()
	{
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 10;
		
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);
		PanelLavadoras.SetActive(false);
		PanelProbar.SetActive(false);
		
		BTNEntregar.SetActive(false);
		BTNTirar.SetActive(false);
		
		StartCoroutine(esperarCamara(tiempo,5));
	}
	
	
	IEnumerator esperarCamara(float _tiempo , int _panel)
	{
		yield return new WaitForSeconds(_tiempo);
		
		
		switch (_panel)
		{
		case 0:
			PanelOpciones.SetActive(true);
			
			
		
			break;
		case 1:
			PanelArma1.SetActive(true);
			PanelArma2.SetActive(false);
			PanelArma3.SetActive(false);
			PanelArma4.SetActive(false);
			break;
		case 2:
			PanelArma1.SetActive(false);
			PanelArma2.SetActive(true);
			PanelArma3.SetActive(false);
			PanelArma4.SetActive(false);
			break;
		case 3:
			PanelArma1.SetActive(false);
			PanelArma2.SetActive(false);
			PanelArma3.SetActive(true);
			PanelArma4.SetActive(false);
			break;
		case 4:
			PanelArma1.SetActive(false);
			PanelArma2.SetActive(false);
			PanelArma3.SetActive(false);
			PanelArma4.SetActive(true);
			break;
			
		case 5:
		
			PanelTienda.SetActive(true);
			break;
		case 6:
			
			PanelLavadoras.SetActive(true);
			break;
		case 7:
			PanelProbar.SetActive(true);
			break;
		}
		
		
		
		
	}
	
	IEnumerator probadorDeArma(){
		
		float duration = 3f; 
		
		float totalTime = 0;
		while(totalTime <= duration)
		{
			BarraCarga.fillAmount = totalTime / duration;
			totalTime += Time.deltaTime;
			var integer = (int)totalTime; /* choose how to quantize this */
			/* convert integer to string and assign to text */
			yield return null;
		}
		
		yield return new WaitForSeconds(1.0f);
		
		BarraCarga.fillAmount = 0/duration;
		
		int _probador= Random.Range(0 , 10);
		
		Debug.Log(_probador);
		
		if(_probador > 5 )
		{
			mensajeArma.text="El arma funciona";
			Debug.Log("El arma funciona");
			BTNEntregar.SetActive(true);
			
		}
		else{
			Debug.Log("no funciono");
			mensajeArma.text="El arma NO funciona";
			BTNTirar.SetActive(true);
		}
		
	}
}
