using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour {

	public SessionData[] sessions;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		SceneManager.LoadScene("Menu");
	}

	public SessionData GetCurrentRoundData() {
		return sessions[0];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
