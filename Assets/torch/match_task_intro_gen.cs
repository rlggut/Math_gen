using UnityEngine;
using System.Collections;

public class match_task_intro_gen : MonoBehaviour {

	public GameObject t1,t2,torch;
	public GameObject p_a,p_b;
	public GameObject ok;
	public int al,bl,a,b;
	private char pl;
	public int[] ch_pl;
	public int[] ch_m;
	public int ch,t;

	private int ap,bp;
	// Use this for initialization
	void Start () {
		ch = 0;
		t = -1;
		ch_pl=new int[10];
		ch_m=new int[10];
		
		for (int i=0; i<10; i++)
			ch_pl [i] = -1;
		
		for (int i=0; i<10; i++)
			ch_m [i] = -1;
		
		
		ch_pl [0] = 8; ch_pl [1]= 7; ch_pl [3]= 9;	ch_pl [6] = 8;ch_pl [9] = 8;
		if (Random.Range (0, 1) == 1)
			ch_pl [5] = 6;
		else
			ch_pl [5] = 9;
		
		ch_m [6] = 5; ch_m [7] = 1;
		if (Random.Range (0, 1) == 1)
			ch_m [8] = 9;
		if (Random.Range (0, 1) == 1)
			ch_m [8] = 6;
		else
			ch_m [8] = 0;
		if (Random.Range (0, 1) == 1)
			ch_m [9] = 5;
		else
			ch_m [9] = 3;
		
		al = 1;bl = 1;
		a = 1;b = 1;
		//		while ((al+bl)==cl) {


		ap=PlayerPrefs.GetInt ("Math_torch&matches_a_prev");
		bp=PlayerPrefs.GetInt ("Math_torch&matches_b_prev");

		while ((al==a)&&(bl==b)) {
			while ((ch_m[bl]==-1) && (ch_m[al]==-1)||((ap==al)&&(bp==bl))) {
				al = Random.Range (0, 9);
				bl = Random.Range (0, 9);
			}
			a = al;
			b = bl;
			if (ch_m [bl] != -1) {
				al=bl;
				a=al;
				b = ch_m [bl];
				ch++;
			} else {
				if (ch_m [al] != -1) {
					bl=al;
					b=bl;
					a = ch_m [al];
					ch++;
				}
			}
		}


//		al = a;bl = b;
		PlayerPrefs.SetInt ("Math_torch&matches_a",a);
		PlayerPrefs.SetInt ("Math_torch&matches_b",b);

		PlayerPrefs.SetInt ("Math_torch&matches_a_prev",a);
		PlayerPrefs.SetInt ("Math_torch&matches_b_prev",b);

		PlayerPrefs.SetInt ("Math_torch&matches_allmatches",0);
		PlayerPrefs.SetInt ("Math_torch&matches_maxmatches",1);
		t1.SetActive (true);
		t2.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		a=PlayerPrefs.GetInt ("Math_torch&matches_a");
		b=PlayerPrefs.GetInt ("Math_torch&matches_b");
		if ((a >= 0) && (b >= 0)) {
			if(a==b){
				if(t==-1) t=100;
				ok.SetActive(true);
			}
		}
		if (t > 0) t--;
		if (t == 0)
			Application.LoadLevel (Application.loadedLevel);
	}
	void OnMouseDown()
	{
		PlayerPrefs.SetInt ("Math_torch&matches_a",al);
		PlayerPrefs.SetInt ("Math_torch&matches_b",bl);
		PlayerPrefs.SetInt ("Math_torch&matches_allmatches",0);
		PlayerPrefs.SetInt ("Math_torch&matches_maxmatches",1);
		ch++;
	}
}