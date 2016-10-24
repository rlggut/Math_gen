using UnityEngine;
using System.Collections;

public class box1_task_create : MonoBehaviour {

	public GameObject ar,ag,aw;

	public GameObject b3,b4,b5,b6,b7,b8,b9;

	public GameObject b1w,b2w,b3w,b4w,b5w,b6w,b7w,b8w,b9w;
	public GameObject b1r,b2r,b3r,b4r,b5r,b6r,b7r,b8r,b9r;
	public GameObject b1g,b2g,b3g,b4g,b5g,b6g,b7g,b8g,b9g;

	public GameObject w1,w2,w3,w4,w5,w6,w7,w8,w9;
	public GameObject r1,r2,r3,r4,r5,r6,r7,r8,r9;
	public GameObject g1,g2,g3,g4,g5,g6,g7,g8,g9;

	public GameObject num9,num8,num7,num6,num5,num4,num3;
	public int t;
	private int w,g,r,all,ch,compl;
	// Use this for initialization
	void Start () {
		t = -1;
		//g r w
		w = Random.Range (1, 5);
		g = Random.Range (6-w, 8-w);
		r = Random.Range (1, 5);


		if (w == 1) { w1.SetActive(true);}
		if (w == 2) { w2.SetActive(true);}
		if (w == 3) { w3.SetActive(true);}
		if (w == 4) { w4.SetActive(true);}
		if (w == 5) { w5.SetActive(true);}
		if (w == 6) { w6.SetActive(true);}
		if (w == 7) { w7.SetActive(true);}
		if (w == 8) { w8.SetActive(true);}
		if (w == 9) { w9.SetActive(true);}

		if (r == 1) { r1.SetActive(true);}
		if (r == 2) { r2.SetActive(true);}
		if (r == 3) { r3.SetActive(true);}
		if (r == 4) { r4.SetActive(true);}
		if (r == 5) { r5.SetActive(true);}
		if (r == 6) { r6.SetActive(true);}
		if (r == 7) { r7.SetActive(true);}
		if (r == 8) { r8.SetActive(true);}
		if (r == 9) { r9.SetActive(true);}

		if (g == 1) { g1.SetActive(true);}
		if (g == 2) { g2.SetActive(true);}
		if (g == 3) { g3.SetActive(true);}
		if (g == 4) { g4.SetActive(true);}
		if (g == 5) { g5.SetActive(true);}
		if (g == 6) { g6.SetActive(true);}
		if (g == 7) { g7.SetActive(true);}
		if (g == 8) { g8.SetActive(true);}
		if (g == 9) { g9.SetActive(true);}

		ch=Random.Range (1, 3);
		PlayerPrefs.SetInt ("math_first_box_ch",ch);
		if (ch == 1) {
			ag.SetActive (true);
			all=r+w+1;
		}
		if (ch == 2) {
			ar.SetActive (true);
			all = g + w + 1;
		}
		if (ch == 3) {
			aw.SetActive (true);
			all = r + g + 1;
		}



		if (ch != 3) {
			b1w.SetActive (true);
			compl = 1;
			if (w >= 2) {
				b2w.SetActive (true);
				compl++;
			}
			if (w >= 3) {
				b3w.SetActive (true);
				compl++;
			}
			if (w >= 4) {
				b4w.SetActive (true);
				compl++;
			}
			if (w >= 5) {
				b5w.SetActive (true);
				compl++;
			}
			
			if (ch == 2) {
				while (w + g > compl) {
					if (compl == 2)
						b3g.SetActive (true);
					if (compl == 3)
						b4g.SetActive (true);
					if (compl == 4)
						b5g.SetActive (true);
					if (compl == 5)
						b6g.SetActive (true);
					if (compl == 6)
						b7g.SetActive (true);
					if (compl == 7)
						b8g.SetActive (true);
					if (compl == 8)
						b9g.SetActive (true);
					compl++;
				}
				
				while ((w + g +r> compl)&&(compl<9)) {
					if (compl == 2)
						b3r.SetActive (true);
					if (compl == 3)
						b4r.SetActive (true);
					if (compl == 4)
						b5r.SetActive (true);
					if (compl == 5)
						b6r.SetActive (true);
					if (compl == 6)
						b7r.SetActive (true);
					if (compl == 7)
						b8r.SetActive (true);
					if (compl == 8)
						b9r.SetActive (true);
					compl++;
				}
			} else {
				while (w + r > compl) {
					if (compl == 2)
						b3r.SetActive (true);
					if (compl == 3)
						b4r.SetActive (true);
					if (compl == 4)
						b5r.SetActive (true);
					if (compl == 5)
						b6r.SetActive (true);
					if (compl == 6)
						b7r.SetActive (true);
					if (compl == 7)
						b8r.SetActive (true);
					if (compl == 8)
						b9r.SetActive (true);
					compl++;
				}
				
				while ((w + g +r> compl)&&(compl<9)) {
					if (compl == 2)
						b3g.SetActive (true);
					if (compl == 3)
						b4g.SetActive (true);
					if (compl == 4)
						b5g.SetActive (true);
					if (compl == 5)
						b6g.SetActive (true);
					if (compl == 6)
						b7g.SetActive (true);
					if (compl == 7)
						b8g.SetActive (true);
					if (compl == 8)
						b9g.SetActive (true);
					compl++;
				}
			}
			
			if (compl < 9)
				b9.SetActive (false);
			if (compl < 8)
				b8.SetActive (false);
			if (compl < 7)
				b7.SetActive (false);
			if (compl < 6)
				b6.SetActive (false);
			if (compl < 5)
				b5.SetActive (false);
			if (compl < 4)
				b4.SetActive (false);
			if (compl < 3)
				b3.SetActive (false);
		} else {
			//ch==3
			b1r.SetActive (true);
			compl = 1;
			if (r >= 2) {
				b2r.SetActive (true);
				compl++;
			}
			if (r >= 3) {
				b3r.SetActive (true);
				compl++;
			}
			if (r >= 4) {
				b4r.SetActive (true);
				compl++;
			}
			if (r >= 5) {
				b5r.SetActive (true);
				compl++;
			}
			while (r + g > compl) {
				if (compl == 2)
					b3g.SetActive (true);
				if (compl == 3)
					b4g.SetActive (true);
				if (compl == 4)
					b5g.SetActive (true);
				if (compl == 5)
					b6g.SetActive (true);
				if (compl == 6)
					b7g.SetActive (true);
				if (compl == 7)
					b8g.SetActive (true);
				if (compl == 8)
					b9g.SetActive (true);
				compl++;
			}
			while ((w + g +r> compl)&&(compl<9)) {
				if (compl == 2)
					b3w.SetActive (true);
				if (compl == 3)
					b4w.SetActive (true);
				if (compl == 4)
					b5w.SetActive (true);
				if (compl == 5)
					b6w.SetActive (true);
				if (compl == 6)
					b7w.SetActive (true);
				if (compl == 7)
					b8w.SetActive (true);
				if (compl == 8)
					b9w.SetActive (true);
				compl++;
			}

			if (compl < 9)
				b9.SetActive (false);
			if (compl < 8)
				b8.SetActive (false);
			if (compl < 7)
				b7.SetActive (false);
			if (compl < 6)
				b6.SetActive (false);
			if (compl < 5)
				b5.SetActive (false);
			if (compl < 4)
				b4.SetActive (false);
			if (compl < 3)
				b3.SetActive (false);

		}


		if (w + r + g <= 8) num9.SetActive (false);
		if (w + r + g <= 7) num8.SetActive (false);
		if (w + r + g <= 6) num7.SetActive (false);
		if (w + r + g <= 5) num6.SetActive (false);
		if (w + r + g <= 4) num5.SetActive (false);
		if (w + r + g <= 3) num4.SetActive (false);
		if (w + r + g <= 2) num3.SetActive (false);



		PlayerPrefs.SetInt ("math_first_box_answ",all);
		PlayerPrefs.SetInt ("math_first_box_sel", 0);
	}
	
	// Update is called once per frame
	void Update () {
		if ((PlayerPrefs.GetInt ("math_first_box_sel") != 0)&&(t==-1))
			t = 140;
		if (t > 0) t--;
		if(t==0) Application.LoadLevel (Application.loadedLevel);
	}
}
