using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject MenuCanvas;

	public void Exit(int id)
	{
		SceneManager.LoadSceneAsync(id);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
			MenuCanvas.SetActive(true);
        }
	}
}
