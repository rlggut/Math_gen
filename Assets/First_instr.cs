using UnityEngine;
using System.Collections;

public class First_instr : MonoBehaviour {

	public string str;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
		if (PlayerPrefs.GetInt (str) == 1)
			gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt (str,1);
		gameObject.SetActive (false);
	}
}
