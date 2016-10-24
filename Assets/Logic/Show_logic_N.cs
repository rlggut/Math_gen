using UnityEngine;
using System.Collections;

public class Show_logic_N : MonoBehaviour {

	public GameObject n1,n2,n3,n4,n5,n6,n7;
	public int num;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (num == 1) {
			if (PlayerPrefs.GetInt ("math_logic_N1") == 1) n1.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N1") == 2) n2.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N1") == 3) n3.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N1") == 4) n4.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N1") == 5) n5.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N1") == 6) n6.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N1") == 7) n7.SetActive (true);
		}
		if (num == 2) {
			if (PlayerPrefs.GetInt ("math_logic_N2") == 1) n1.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N2") == 2) n2.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N2") == 3) n3.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N2") == 4) n4.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N2") == 5) n5.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N2") == 6) n6.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N2") == 7) n7.SetActive (true);
		}
		if (num == 3) {
			if (PlayerPrefs.GetInt ("math_logic_N3") == 1) n1.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N3") == 2) n2.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N3") == 3) n3.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N3") == 4) n4.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N3") == 5) n5.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N3") == 6) n6.SetActive (true);
			if (PlayerPrefs.GetInt ("math_logic_N3") == 7) n7.SetActive (true);
		}
	}
}