using UnityEngine;
using System.Collections;

public class TaskCat_gen_easy : MonoBehaviour {
	public int cat,kitty,a,b,c,d,e,f,t;
	public GameObject Ok;
	// Use this for initialization
	void Start () {
		t = -1;
		PlayerPrefs.SetInt ("Ballance_w_sel", 0);
		PlayerPrefs.SetInt ("Ballance_Cat11",0);PlayerPrefs.SetInt ("Ballance_Cat21",0);
		PlayerPrefs.SetInt ("Ballance_Cat12",0);PlayerPrefs.SetInt ("Ballance_Cat22",0);
		PlayerPrefs.SetInt ("Ballance_Kitty11",0);PlayerPrefs.SetInt ("Ballance_Kitty12",0);
		PlayerPrefs.SetInt ("Ballance_Kitty21",0);PlayerPrefs.SetInt ("Ballance_Kitty22",0);

		for (c=1; c<=13; c++) {
			PlayerPrefs.SetInt ("Ballance_w" + c.ToString () + "1", 0);
			PlayerPrefs.SetInt ("Ballance_w" + c.ToString () + "2", 0);
		}
		
		kitty=Random.Range (1, 3);
		cat=Random.Range (kitty+1, 5);
		a=Random.Range (1, 2);
		b = 5;
		while(a+b>3) b=Random.Range (1, 2);
		c = a * cat + b * kitty;
		if(a>=1)
			PlayerPrefs.SetInt ("Ballance_Cat11",1);
		if(a==2)
			PlayerPrefs.SetInt ("Ballance_Cat21",1);
		
		if(b>=1)
			PlayerPrefs.SetInt ("Ballance_Kitty11",1);
		if(b>=2)
			PlayerPrefs.SetInt ("Ballance_Kitty21",1);

		PlayerPrefs.SetInt ("Ballance_w"+c.ToString()+"1", 1);
		
	

		d = 0;
		e = b;
		while (((e==0)&&(d==0))||((d==a)&&(e==b))) {
				e = Random.Range (0, 2);
		}
		
		f = d * cat + e * kitty;
		if(d>=1)
			PlayerPrefs.SetInt ("Ballance_Cat12",1);
		if(d==2)
			PlayerPrefs.SetInt ("Ballance_Cat22",1);
		
		if(e>=1)
			PlayerPrefs.SetInt ("Ballance_Kitty12",1);
		if(e>=2)
			PlayerPrefs.SetInt ("Ballance_Kitty22",1);
		if(e==3)
			PlayerPrefs.SetInt ("Ballance_Kitty32",1);
		
		PlayerPrefs.SetInt ("Ballance_w"+f.ToString()+"2", 1);
	}
	
	// Update is called once per frame
	void Update () {
		if ((cat == PlayerPrefs.GetInt ("Ballance_w_sel"))) {
			Ok.SetActive(true);
			PlayerPrefs.SetInt ("Ballance_w_sel", -1);
			if(t==-1) t=100;
		}
		if (t > 0) t--;
		if (t == 0)
			Application.LoadLevel (Application.loadedLevel);
	}
}
