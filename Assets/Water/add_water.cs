using UnityEngine;
using System.Collections;

public class add_water : MonoBehaviour {

	public int i;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (i == 1)
			PlayerPrefs.SetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString (), PlayerPrefs.GetInt ("selected_water"));
		else
			PlayerPrefs.SetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString (), 0);
		PlayerPrefs.SetInt ("selected_water", 0);
	}
}
