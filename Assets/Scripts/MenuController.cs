﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class MenuController : MonoBehaviour
{
	public RectTransform mainMenu, CreditosMenu;
    // Start is called before the first frame update
    void Start()
    {
	    mainMenu.DOAnchorPos(Vector2.zero, 0.25f);
    }

   
	public void CreditsBTN()
	{
		mainMenu.DOAnchorPos(new Vector2(-2000, 0), 0.25f);
		CreditosMenu.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
	}
	
	public void BackMenu()
	{
		CreditosMenu.DOAnchorPos(new Vector2(2000, 0), 0.25f);
		mainMenu.DOAnchorPos(new Vector2(0,0), 0.25f).SetDelay(0.25f);
	}
	
	public void startGame()
	{
		SceneManager.LoadScene(1);
	}
}