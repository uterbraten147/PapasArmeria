using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class GameMan : MonoBehaviour
{
	
	public GameObject  PanelOpciones, MesaPanel;
	public CinemachineVirtualCamera VCamMesa, VCamOptions;
    // Start is called before the first frame update
    void Start()
	{
		PanelOpciones.SetActive(false);
		MesaPanel.SetActive(true);
		VCamMesa.Priority = 10;
		VCamOptions.Priority= 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
	public void SettingsBTN()
	{
		PanelOpciones.SetActive(true);
		MesaPanel.SetActive(false);
		VCamMesa.Priority = 0;
		VCamOptions.Priority= 10;
		
	}
	
	public void MesaBTN()
	{
		PanelOpciones.SetActive(false);
		MesaPanel.SetActive(true);
		VCamMesa.Priority = 10;
		VCamOptions.Priority= 0;
		
	}
}
