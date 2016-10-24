using UnityEngine;
using System.Collections;

public class match_task_gen : MonoBehaviour {

	public GameObject t1,t2,t3,torch;
	public GameObject p_a,p_pl,p_b,p_c;
	public GameObject ok;
	public int al,bl,cl,a,b,c;
	private char pl;
	public int[] ch_pl;
	public int[] ch_m;
	public int ch,t;
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
		
		al = 1;bl = 1;cl = 2;
//		while ((al+bl)==cl) {

			while (! ( ((ch_pl[al]!=-1)&&(ch_m[bl]!=-1)) || ((ch_pl[al]!=-1)&&(ch_m[cl]!=-1)) || ((ch_pl[bl]!=-1)&&(ch_m[cl]!=-1))
			          || ((ch_pl[bl]!=-1)&&(ch_m[al]!=-1)) || ((ch_pl[cl]!=-1)&&(ch_m[bl]!=-1)) || ((ch_pl[cl]!=-1)&&(ch_m[al]!=-1)) )) {
				al = Random.Range (0, 7);
				bl = Random.Range (0, 9 - al);
				cl = al + bl;
				a = al;
				b = bl;
				c = cl;
			}

			if ((ch_pl [al] != -1) && (ch_m [bl] != -1)) {
				a = ch_pl [al];
				b = ch_m [bl];
				c = cl;
				ch++;
			} else {
				if ((ch_pl [al] != -1) && (ch_m [cl] != -1)) {
					a = ch_pl [al];
					b = bl;
					c = ch_m [cl];
					ch++;
				} else {
					if ((ch_pl [bl] != -1) && (ch_m [cl] != -1)) {
						a = al;
						b = ch_pl [bl];
						c = ch_m [cl];
						ch++;
					} else {
						if ((ch_pl [bl] != -1) && (ch_m [al] != -1)) {
							a = ch_m [al];
							b = ch_pl [bl];
							c = cl;
							ch++;
						} else {
							if ((ch_pl [cl] != -1) && (ch_m [bl] != -1)) {
								a = al;
								b = ch_m [bl];
								c = ch_pl [cl];
								ch++;
							} else {
								if ((ch_pl [cl] != -1) && (ch_m [al] != -1)) {
									a = ch_m [al];
									b = bl;
									c = ch_pl [cl];
									ch++;
								}
							}
						}
					}
				}
			}
		al = a;bl = b;cl = c;
		PlayerPrefs.SetInt ("Math_torch&matches_a",a);
		PlayerPrefs.SetInt ("Math_torch&matches_b",b);
		PlayerPrefs.SetInt ("Math_torch&matches_c",c);
		PlayerPrefs.SetInt ("Math_torch&matches_allmatches",0);
		PlayerPrefs.SetInt ("Math_torch&matches_maxmatches",1);
		pl = '+';
		t1.SetActive (true);
		t2.SetActive (true);
		t3.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		a=PlayerPrefs.GetInt ("Math_torch&matches_a");
		b=PlayerPrefs.GetInt ("Math_torch&matches_b");
		c=PlayerPrefs.GetInt ("Math_torch&matches_c");
		if ((a >= 0) && (b >= 0) && (c >= 0)) {
			if(PlayerPrefs.GetString ("Math_torch&matches_pl")=="+")
			{
				if(a+b==c){
					if(t==-1) t=100;
					ok.SetActive(true);
				}

			}
			if(PlayerPrefs.GetString ("Math_torch&matches_pl")=="-")
			{
				if(a-b==c)
				{
					if(t==-1) t=100;
					ok.SetActive(true);
				}
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
		PlayerPrefs.SetInt ("Math_torch&matches_c",cl);
		PlayerPrefs.SetString ("Math_torch&matches_pl_r","+");
		PlayerPrefs.SetInt ("Math_torch&matches_allmatches",0);
		PlayerPrefs.SetInt ("Math_torch&matches_maxmatches",1);
		ch++;
	}
}
