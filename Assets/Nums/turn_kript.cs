using UnityEngine;
using System.Collections;

public class turn_kript : MonoBehaviour {

	public int num,index;
	public int c1,c2,c3,c4,c5,c6,c7,c8;
	private int t;
	// Use this for initialization
	void Start () {
		t = -1;
		num = Random.Range (0, 6);
		transform.Rotate(new Vector3(0,0,45*num));
	}
	
	// Update is called once per frame
	void Update () {
		if (t >= 0) {
			transform.Rotate(new Vector3(0,0,3));
			t--;
		}

		if (num == 0)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c1);
		if (num == 1)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c2);
		if (num == 2)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c3);
		if (num == 3)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c4);
		if (num == 4)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c5);
		if (num == 5)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c6);
		if (num == 6)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c7);
		if (num == 7)
			PlayerPrefs.SetInt ("kript_" + index.ToString (), c8);
	}

	void OnMouseDown()
	{
		if (t == -1) {
			t = 14;
			num++;
			num=num%8;
		}
	}

}
