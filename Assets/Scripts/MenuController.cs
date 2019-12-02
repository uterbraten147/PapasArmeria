using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class MenuController : MonoBehaviour
{
	public RectTransform mainMenu, CreditosMenu, imagenMenu, BotonesMenu, cargandoPanel;
	//	public Image imagenCarga;
	//double img = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
	    mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
	    imagenMenu.DOAnchorPos(Vector2.zero, 0.40f).SetDelay(0.25f);
	    BotonesMenu.DOAnchorPos(Vector2.zero, 0.40f).SetDelay(0.25f);
	    // img = 0.0f;
    }

   
	public void CreditsBTN()
	{
		mainMenu.DOAnchorPos(new Vector2(0, 2000), 0.25f);
		imagenMenu.DOAnchorPos(new Vector2(2000, 0), 0.35f);
		BotonesMenu.DOAnchorPos(new Vector2(-2000, 0), 0.35f);
		CreditosMenu.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
	}
	
	public void BackMenu()
	{
		CreditosMenu.DOAnchorPos(new Vector2(0, -2000), 0.25f);
		mainMenu.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
		imagenMenu.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
		BotonesMenu.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
	}
	
	public void startGame()
	{
		StartCoroutine(cargarJuego());
	}
	
	IEnumerator cargarJuego()
	{
		mainMenu.DOAnchorPos(new Vector2(0, 2000), 0.25f);
		imagenMenu.DOAnchorPos(new Vector2(2000, 0), 0.35f);
		BotonesMenu.DOAnchorPos(new Vector2(-2000, 0), 0.35f);
		cargandoPanel.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
		/*	bool cargado = false;
		while(!cargado)
		{
			
			img ++;
			
			imagenCarga.fillAmount = img / 100;
			
			if(img >= 100){
				
				cargado = true;
			}
			
			
		}*/
		
		yield return new WaitForSeconds (3);
		
		AsyncOperation async = SceneManager.LoadSceneAsync(1);
		while (!async.isDone)
		{
			yield return null;
		}

		
	}
}
