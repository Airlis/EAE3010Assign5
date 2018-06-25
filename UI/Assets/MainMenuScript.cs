using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

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

	public void PlayButtonClicked ()
	{
	  canvas.SendMessage ("MenuDisplay", "Play");
	}

	public void QuitButtonClicked ()
	{
	  Application.Quit();
	  UnityEditor.EditorApplication.isPlaying = false;
	}
}
