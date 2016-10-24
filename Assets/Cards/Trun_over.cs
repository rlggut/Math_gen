using UnityEngine;
using System.Collections;

public class Trun_over : MonoBehaviour {
	public GameObject cards;
	private int t;
	// Use this for initialization
	void Start () {
		t = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if (t >=0) t--;
		if (t == 0) {
			cards.transform.Rotate (0, -180, 0);
			PlayerPrefs.SetInt ("Cards_next", 1);
		}
	}

	void OnMouseDown()
	{
		if (PlayerPrefs.GetInt ("Cards_turn") == 0) {
			t = 100;
			cards.transform.Rotate (0, 180, 0);
			PlayerPrefs.SetInt ("Cards_turn", 1);
		}
	}
}
