using UnityEngine;
using System.Collections;

public class show_task : MonoBehaviour {

	public int num,p;
	public GameObject p1,p2;

	public int t;
	private int sp;

	private int i;
	private bool fl;
	// Use this for initialization
	void Start () {
		t = -1;
		sp = 1;
		PlayerPrefs.SetInt ("math_tasks_list_act"+num.ToString(), 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (t >= 0) {
			t--;
			p1.transform.position+=new Vector3 (0,0,p*0.2f);
			p2.transform.position+=new Vector3 (0,0,p*0.1f);
		}
		if ((t == -1) && (sp == -1)) {
			PlayerPrefs.SetInt ("math_tasks_list_act" + num.ToString (), 0);
			sp=1;
		}
	}
	void OnMouseDown(){
		fl = true;
		for (i=1; i<=100; i++)
			if (PlayerPrefs.GetInt ("math_tasks_list_act" + i.ToString ()) != 0)
				fl = false;

		if (fl) {
			PlayerPrefs.SetInt ("math_tasks_list_act"+num.ToString(), 1);
			t = 50;
			sp=-1;
		}
	}
}