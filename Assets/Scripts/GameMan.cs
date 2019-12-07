using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class GameMan : MonoBehaviour
{
	
	public GameObject  PanelOpciones, PanelArma1, PanelArma2, PanelArma3, PanelArma4, PanelTienda;
	public CinemachineVirtualCamera VCamMesa, VCamOptions, VCamArmaTest, VCamShop;
	float tiempo = 2.0f;


    // Start is called before the first frame update
    void Start()
	{
		PanelTienda.SetActive(true);
		
		PanelOpciones.SetActive(false);
		
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);

		VCamMesa.Priority = 0;
		VCamOptions.Priority= 0;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 10;
		
		
    }

   
    
    
	public void SettingsBTN()
	{
	
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 10;
		VCamArmaTest.Priority=0;
		VCamShop.Priority = 0;
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
		
		PanelArma1.SetActive(false);
		PanelArma2.SetActive(false);
		PanelArma3.SetActive(false);
		PanelArma4.SetActive(false);
		PanelOpciones.SetActive(false);
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
		}
		
		
		
		
	}
}
