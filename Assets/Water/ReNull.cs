using UnityEngine;
using System.Collections;

public class ReNull : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("water1", 0);
		PlayerPrefs.SetInt ("water2", 0);
		PlayerPrefs.SetInt ("water3", 0);
		PlayerPrefs.SetInt ("water4", 0);
		PlayerPrefs.SetInt ("water5", 0);
		PlayerPrefs.SetInt ("water6", 0);
		PlayerPrefs.SetInt ("water7", 0);
		PlayerPrefs.SetInt ("selected_water",0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
