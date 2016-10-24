using UnityEngine;
using System.Collections;

public class Trun_acc : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		if (PlayerPrefs.GetInt ("Cards_turn") == 0) {
			PlayerPrefs.SetInt ("Cards_next", 1);
		}
	}
}
