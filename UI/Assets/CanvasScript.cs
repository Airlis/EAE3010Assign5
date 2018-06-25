using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour {

	public GameObject MainMenu;
	public GameObject PauseMenu;
	public GameObject OptionMenu;
	public GameObject HUD;

	int status = 1;

	// Use this for initialization
	void Start () {
	    MenuDisplay ("MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
		
	  if (status == 0 && Input.GetKeyDown(KeyCode.Escape))
          {        
              MenuDisplay ("PauseMenu");
          }
	}

	void MenuDisplay (string id)
	{
	    if (id == "MainMenu")
	    {
		MainMenu.SetActive (true);
		PauseMenu.SetActive (false);
		OptionMenu.SetActive (false);
		HUD.SetActive (false);
		status = 1;
	    }
	    if (id == "OptionMenu")
	    {
		MainMenu.SetActive (false);
		PauseMenu.SetActive (false);
		OptionMenu.SetActive (true);
		HUD.SetActive (false);
		status = 1;
	    }
	    if (id == "PauseMenu")
	    {
		MainMenu.SetActive (false);
		PauseMenu.SetActive (true);
		OptionMenu.SetActive (false);
		HUD.SetActive (false);
		status = 1;
	    }
	    if (id == "Play")
	    {
		MainMenu.SetActive (false);
		PauseMenu.SetActive (false);
		OptionMenu.SetActive (false);
		HUD.SetActive (true);
		status = 0;
	    }
	}
}
