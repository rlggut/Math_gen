using UnityEngine;
using System.Collections;

public class List_next : MonoBehaviour {

	public int max;
	public int num;
	public int list_numb;
	public GameObject p1,p2,line;

	public int pos,t;
	public int sp;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt ("math_tasks_list"+list_numb.ToString(), max);
		PlayerPrefs.SetInt ("math_tasks_list"+list_numb.ToString()+"_pos", 1);
	
		PlayerPrefs.SetInt ("math_tasks_list"+list_numb.ToString()+"_act2", 0);

		pos = 1;
		t = -1;
		sp = -1;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		max = PlayerPrefs.GetInt ("math_tasks_list" + list_numb.ToString ());
		pos = PlayerPrefs.GetInt ("math_tasks_list" + list_numb.ToString () + "_pos");

		if (pos == 1)
			p2.SetActive (false);
		else
			p2.SetActive (true);

		if (pos == max)
			p1.SetActive (false);
		else
			p1.SetActive (true);
	
		while (t>=0) {
			line.transform.position += new Vector3 (-num * 0.2f, 0, 0);
			t--;
		}

		if ((sp == 1) && (t == -1)) {
			PlayerPrefs.SetInt ("math_tasks_list" + list_numb.ToString () + "_act2", 0);
			PlayerPrefs.SetInt ("math_tasks_list"+list_numb.ToString()+"_pos",PlayerPrefs.GetInt ("math_tasks_list"+list_numb.ToString()+"_pos")+num);
			sp = -1;
		}
	}
	void OnMouseDown(){
		if (PlayerPrefs.GetInt ("math_tasks_list"+list_numb.ToString()+"_act2") == 0) {
			t = 80;
			sp=1;
			PlayerPrefs.SetInt ("math_tasks_list"+list_numb.ToString()+"_act2", 1);
		}
	}

}
