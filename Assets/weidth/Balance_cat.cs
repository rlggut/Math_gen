using UnityEngine;
using System.Collections;

public class Balance_cat : MonoBehaviour {

	public int num;
	public GameObject cat1, cat2,kitty1,kitty2,kitty3;
	public GameObject w1,w2,w3,w4,w5,w6,w7,w8,w9,w10,w11,w12,w13,w14,w15,w16,w17,w18;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void LateUpdate () {
		cat1.SetActive (false);
		cat2.SetActive (false);
		kitty1.SetActive (false);
		kitty2.SetActive (false);
		kitty3.SetActive (false);

		if (PlayerPrefs.GetInt ("Ballance_Cat1"+num.ToString()) == 1) cat1.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_Cat2"+num.ToString()) == 1) cat2.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_Kitty1"+num.ToString()) == 1) kitty1.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_Kitty2"+num.ToString()) == 1) kitty2.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_Kitty3"+num.ToString()) == 1) kitty3.SetActive (true);

		w1.SetActive (false);w2.SetActive (false);w3.SetActive (false);w4.SetActive (false);w5.SetActive (false);
		w6.SetActive (false);w7.SetActive (false);w8.SetActive (false);w9.SetActive (false);w10.SetActive (false);
		w11.SetActive (false);w12.SetActive (false);w13.SetActive (false);w14.SetActive (false);w15.SetActive (false);
		w16.SetActive (false);w17.SetActive (false);w18.SetActive (false);
		
		if (PlayerPrefs.GetInt ("Ballance_w1"+num.ToString()) == 1) w1.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w2"+num.ToString()) == 1) w2.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w3"+num.ToString()) == 1) w3.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w4"+num.ToString()) == 1) w4.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w5"+num.ToString()) == 1) w5.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w6"+num.ToString()) == 1) w6.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w7"+num.ToString()) == 1) w7.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w8"+num.ToString()) == 1) w8.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w9"+num.ToString()) == 1) w9.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w10"+num.ToString()) == 1) w10.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w11"+num.ToString()) == 1) w11.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w12"+num.ToString()) == 1) w12.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w13"+num.ToString()) == 1) w13.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w14"+num.ToString()) == 1) w14.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w15"+num.ToString()) == 1) w15.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w16"+num.ToString()) == 1) w16.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w17"+num.ToString()) == 1) w17.SetActive (true);
		if (PlayerPrefs.GetInt ("Ballance_w18"+num.ToString()) == 1) w18.SetActive (true);
	}
}
