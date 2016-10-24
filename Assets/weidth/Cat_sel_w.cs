using UnityEngine;
using System.Collections;

public class Cat_sel_w : MonoBehaviour {

	public int num;
	public GameObject sel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Ballance_w_sel") == num)
			sel.SetActive (true);
		else
			sel.SetActive (false);
	}
	void OnMouseDown()
	{
		if (PlayerPrefs.GetInt ("Ballance_w_sel") >= 0)
			PlayerPrefs.SetInt ("Ballance_w_sel", num);
	}
}
