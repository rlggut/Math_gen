
using UnityEngine;
using System.Collections;

public class Kript_lvl1 : MonoBehaviour {
	public GameObject Ok;
	public int a,b,c,eq1;
	private int t;
	// Use this for initialization
	void Start () {
		t = -1;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		a = PlayerPrefs.GetInt ("kript_1");
		eq1 = PlayerPrefs.GetInt ("kript_2");
		b = PlayerPrefs.GetInt ("kript_3");
		c = PlayerPrefs.GetInt ("kript_5");
		if (eq1 == 10) {
			if ((a + b == c) && (t == -1))
				t = 50;
		} else {
			if (eq1 == 11) {
				if ((a - b == c) && (t == -1))
					t = 50;
			} else
			{
				if (eq1 == 13) {
					if ((a * b == c) && (t == -1))
						t = 50;
				}
				else
				{
					if ((eq1 == 14)&&(b!=0)) {
						if ((c * b == a) && (t == -1))
							t = 50;
					}
				}
			}
		}
		if (t > 0) {
			if(t==30) Ok.SetActive(true);
			t--;
		}
		if (t == 0)
			Application.LoadLevel (Application.loadedLevel);
	}
}
