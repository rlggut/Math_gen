using UnityEngine;
using System.Collections;

public class match_plus : MonoBehaviour {

	public GameObject p1,p2;
	private bool i1,i2;
	private char def;
	private string tp;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetString ("Math_torch&matches_pl_r", "0");
	}
	
	// Update is called once per frame
	void LateUpdate () {
		tp = PlayerPrefs.GetString ("Math_torch&matches_pl_r");
		if (tp == "+") {
			p1.SetActive (true);
			p2.SetActive (true);
			PlayerPrefs.SetString ("Math_torch&matches_pl_r", "0");
		}
		if (tp == "-") {
			p1.SetActive (false);
			p2.SetActive (true);
			PlayerPrefs.SetString ("Math_torch&matches_pl_r", "0");
		}

		def = '0';
		i1=p1.activeSelf;
		i2=p2.activeSelf;

		if (i1 && i2) {
			def='+';
		}
		else
		{
			if ((!i1) && i2) {
				def='-';
			}
		}
		PlayerPrefs.SetString ("Math_torch&matches_pl",def.ToString());
	}
}
