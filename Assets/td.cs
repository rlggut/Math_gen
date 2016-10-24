using UnityEngine;
using System.Collections;

public class td : MonoBehaviour {

	public string url = "";

	void Start () {
	}
	
	void Update () {
	}

	void OnMouseDown()
	{
		Application.OpenURL (url);
	}
}
