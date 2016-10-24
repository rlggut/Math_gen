using UnityEngine;
using System.Collections;

public class TaskLogis_sentences : MonoBehaviour {
	public int n1,n2,n3,t;
	public GameObject ok,p1,p2,p3,p4,p5,p6,p7;
	// Use this for initialization
	void Start () {
		t=-1;
		n1 = Random.Range (1, 7);

		n2 = Random.Range (1, 7);
		while (n2==n1)
			n2 = Random.Range (1, 7);

		n3 = Random.Range (1, 7);
		while ((n3==n1)||(n3==n2))
			n3 = Random.Range (1, 7);

		PlayerPrefs.SetInt ("math_logic_N1", n1);
		PlayerPrefs.SetInt ("math_logic_N2", n2);
		PlayerPrefs.SetInt ("math_logic_N3", n3);

		PlayerPrefs.SetInt ("math_logic_sel", 0);
		if (Random.Range (1, 3) == 1) {
			PlayerPrefs.SetInt ("math_logic_ans", 1);
			if(n1==1) p1.SetActive(true);
			if(n1==2) p2.SetActive(true);
			if(n1==3) p3.SetActive(true);
			if(n1==4) p4.SetActive(true);
			if(n1==5) p5.SetActive(true);
			if(n1==6) p6.SetActive(true);
			if(n1==7) p7.SetActive(true);
		}else{
			if (Random.Range (1, 3) == 2) {
				PlayerPrefs.SetInt ("math_logic_ans", 2);
				if(n2==1) p1.SetActive(true);
				if(n2==2) p2.SetActive(true);
				if(n2==3) p3.SetActive(true);
				if(n2==4) p4.SetActive(true);
				if(n2==5) p5.SetActive(true);
				if(n2==6) p6.SetActive(true);
				if(n2==7) p7.SetActive(true);
			}else{
				PlayerPrefs.SetInt ("math_logic_ans", 3);
				if(n3==1) p1.SetActive(true);
				if(n3==2) p2.SetActive(true);
				if(n3==3) p3.SetActive(true);
				if(n3==4) p4.SetActive(true);
				if(n3==5) p5.SetActive(true);
				if(n3==6) p6.SetActive(true);
				if(n3==7) p7.SetActive(true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if ((t==-1)&&(PlayerPrefs.GetInt ("math_logic_ans") == PlayerPrefs.GetInt ("math_logic_sel"))) {
			ok.SetActive (true);
			t = 140;
		}
		if (t > 0) t--;
		if(t==0) Application.LoadLevel (Application.loadedLevel);
	}
}
