using UnityEngine;
using System.Collections;

public class Tree_Logic : MonoBehaviour {

	public GameObject tr,tr_c1,tr_c1_del,tr_l1,tr_l1_del;

	public int t,c;
	// Use this for initialization
	void Start () {
		c = 0;
		t = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if ((c == 0) & (t < 0))
			tr.SetActive (true);
		if ((c == 1) & (t < 0)) {
			tr_c1.SetActive (true);
			tr_c1_del.SetActive(false);
		}
		if ((c == 2) & (t < 0)) {
			tr_l1_del.SetActive (false);
			tr_l1.SetActive (true);
		}
		if (t < 0) {
			c++;
			t = 200;
		}
		if(t>=0) t--;
	}
}
