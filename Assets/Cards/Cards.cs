using UnityEngine;
using System.Collections;

public class Cards : MonoBehaviour {
	public GameObject c1,c2,c3,c4;

	private int r,t;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("Cards_next", 1);
		PlayerPrefs.SetInt ("Cards_turn", 0);
		r=0;
	}
	void cards()
	{
		c1.SetActive (false);
		c2.SetActive (false);
		c3.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("Cards_next") == 1) {
			PlayerPrefs.SetInt ("Cards_next", 0);
			PlayerPrefs.SetInt ("Cards_turn", 0);
			t=r;
			cards();
			while(t==r) t=Random.Range(1,4);
			if(t==1) c1.SetActive(true);
			if(t==2) c2.SetActive(true);
			if(t==3) c3.SetActive(true);
			r=t;
		}
	}
}
