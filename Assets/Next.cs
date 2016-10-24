using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour {
	public int num;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		Application.LoadLevel (num);
	}
}
