using UnityEngine;
using System.Collections;

public class WaterBottle : MonoBehaviour {

	public GameObject w1,w2,w3,w4,w5,w6,w7,ok;
	public int num;

	public int sel;

	private int c,j;
	// Use this for initialization
	void Start () {
		ok.SetActive (false);
	}
	void nul()
	{
		w1.SetActive (false);
		w2.SetActive (false);
		w3.SetActive (false);
		w4.SetActive (false);
		w5.SetActive (false);
		w6.SetActive (false);
		w7.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		nul ();
		c=PlayerPrefs.GetInt ("water" + num.ToString ());
		if (c == 1) w1.SetActive (true);
		if (c == 2) w2.SetActive (true);
		if (c == 3) w3.SetActive (true);
		if (c == 4) w4.SetActive (true);
		if (c == 5) w5.SetActive (true);
		if (c == 6) w6.SetActive (true);
		if (c == 7) w7.SetActive (true);

		sel=PlayerPrefs.GetInt ("selected_water");
		if (PlayerPrefs.GetInt ("selected_water") == num)
			ok.SetActive (true);
		else ok.SetActive(false);
	}
	void OnMouseDown()
	{
		if (PlayerPrefs.GetInt ("selected_water") >= 0)
			if (PlayerPrefs.GetInt ("selected_water") == 0) {
				PlayerPrefs.SetInt ("selected_water", num);
			} else {
				if (PlayerPrefs.GetInt ("selected_water") == num) {
					PlayerPrefs.SetInt ("selected_water", 0);
				} else {
					j = num - PlayerPrefs.GetInt ("water" + num.ToString());
					if(j<PlayerPrefs.GetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString()))
					{
						PlayerPrefs.SetInt ("water" + num.ToString (),num);
						PlayerPrefs.SetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString(),PlayerPrefs.GetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString())-j);
					}
					else
					{
						PlayerPrefs.SetInt ("water" + num,
						                    PlayerPrefs.GetInt ("water" + num.ToString())+PlayerPrefs.GetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString()));
						PlayerPrefs.SetInt ("water" + PlayerPrefs.GetInt ("selected_water").ToString (),0);
					}
					PlayerPrefs.SetInt ("selected_water", 0);
				}
			}
	}
}
