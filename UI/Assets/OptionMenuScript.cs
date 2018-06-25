using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenuScript : MonoBehaviour {

	public GameObject canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OptionButtonClicked ()
	{
	  canvas.SendMessage ("MenuDisplay", "OptionMenu");
	  //Canvas.MenuDisplay("OptionMenu");
	}

	public void MainButtonClicked ()
	{
	  canvas.SendMessage ("MenuDisplay", "MainMenu");
	}
}
