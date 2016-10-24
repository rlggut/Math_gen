using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {

	public string whith_what;
	public GameObject whith_that;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt (whith_what,0);
		whith_that.SetActive (true);
	}
}
