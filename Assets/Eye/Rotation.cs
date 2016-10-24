using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public GameObject s1,s2,s3,s4,s5,s6,s7,s8,s9,s10;

	private int t,i;
	// Use this for initialization
	void Start () {
		s1.SetActive (true);
		s2.SetActive (false);
		s3.SetActive (false);
		s4.SetActive (false);
		s5.SetActive (false);
		s6.SetActive (false);
		s7.SetActive (false);
		s8.SetActive (false);
		s9.SetActive (false);
		s10.SetActive (false);
		t = 4;
		i=1;
	}
	
	// Update is called once per frame
	void Update () {
		t--;
		transform.Rotate (new Vector3 (1, 1, 1));
		if (t == 0) {
			i=i%10+1;
			if(i==1){ s1.SetActive(true); s10.SetActive(false);}
			if(i==2){ s2.SetActive(true); s1.SetActive(false);}
			if(i==3){ s3.SetActive(true); s2.SetActive(false);}
			if(i==4){ s4.SetActive(true); s3.SetActive(false);}
			if(i==5){ s5.SetActive(true); s4.SetActive(false);}
			if(i==6){ s6.SetActive(true); s5.SetActive(false);}
			if(i==7){ s7.SetActive(true); s6.SetActive(false);}
			if(i==8){ s8.SetActive(true); s7.SetActive(false);}
			if(i==9){ s9.SetActive(true); s8.SetActive(false);}
			if(i==10){ s10.SetActive(true); s9.SetActive(false);}
			t=4;
		}
	}
}
