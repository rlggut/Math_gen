using UnityEngine;
using System.Collections;

public class logic_box_sel : MonoBehaviour {
	public int num;
	public GameObject sel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("math_logic_sel") == num)
			sel.SetActive (true);
		else
			sel.SetActive (false);
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt ("math_logic_sel", num);
	}
}
