using UnityEngine;
using System.Collections;

public class torch_numb : MonoBehaviour {

	public GameObject p1,p2,p3,p4,p5,p6,p7;
	public GameObject np1,np2,np3,np4,np5,np6,np7;

	private bool i1,i2,i3,i4,i5,i6,i7;
	public int num,tp;
	public char bu;
	// Use this for initialization
	void bill()
	{
		num = PlayerPrefs.GetInt ("Math_torch&matches_" + bu.ToString ());
		if (num == 9) {
			i1 = false;
			i2 = true;
			i3 = true;
			i4 = true;
			i5 = true;
			i6 = true;
			i7 = true;
		}
		if (num == 8) {
			i1 = true;
			i2 = true;
			i3 = true;
			i4 = true;
			i5 = true;
			i6 = true;
			i7 = true;
		}
		if (num == 7) {
			i1 = false;
			i2 = false;
			i3 = true;
			i4 = true;
			i5 = false;
			i6 = true;
			i7 = false;
		}
		if (num == 6) {
			i1 = true;
			i2 = true;
			i3 = true;
			i4 = false;
			i5 = true;
			i6 = true;
			i7 = true;
		}
		if (num == 5) {
			i1 = false;
			i2 = true;
			i3 = true;
			i4 = false;
			i5 = true;
			i6 = true;
			i7 = true;
		}
		if (num == 4) {
			i1 = false;
			i2 = true;
			i3 = false;
			i4 = true;
			i5 = true;
			i6 = true;
			i7 = false;
		}
		if (num == 3) {
			i1 = false;
			i2 = false;
			i3 = true;
			i4 = true;
			i5 = true;
			i6 = true;
			i7 = true;
		}
		if (num == 2) {
			i1 = true;
			i2 = false;
			i3 = true;
			i4 = true;
			i5 = true;
			i6 = false;
			i7 = true;
		}
		if (num == 1) {
			i1 = false;
			i2 = false;
			i3 = false;
			i4 = true;
			i5 = false;
			i6 = true;
			i7 = false;
		}
		if (num == 0) {
			i1 = true;
			i2 = true;
			i3 = true;
			i4 = true;
			i5 = false;
			i6 = true;
			i7 = true;
		}
		
		p1.SetActive (i1);
		p2.SetActive (i2);
		p3.SetActive (i3);
		p4.SetActive (i4);
		p5.SetActive (i5);
		p6.SetActive (i6);
		p7.SetActive (i7);
		
		np1.SetActive (!i1);
		np2.SetActive (!i2);
		np3.SetActive (!i3);
		np4.SetActive (!i4);
		np5.SetActive (!i5);
		np6.SetActive (!i6);
		np7.SetActive (!i7);
	}
	void Start () {
		bill ();
	}
	
	// Update is called once per frame
	void Update () {
		if (num != PlayerPrefs.GetInt ("Math_torch&matches_" + bu.ToString ())) {
			bill ();
		}

		i1=p1.activeSelf;
		i2=p2.activeSelf;
		i3=p3.activeSelf;
		i4=p4.activeSelf;
		i5=p5.activeSelf;
		i6=p6.activeSelf;
		i7=p7.activeSelf;


		if ((!i1) && i2 && i3 && i4 && i5 && i6 && i7){
			num = 9;
		} else {
			if (i1 && i2 && i3 && i4 && i5 && i6 && i7)  {
				num = 8;
			} else {
				if ((!i1) && (!i2) && i3 && i4 && (!i5) && i6 && (!i7)) {
					num = 7;
				} else {
					if (i1 && i2 && i3 && (!i4) && i5 && i6 && i7) {
						num = 6;
					} else {
						if ((!i1) && i2 && i3 && (!i4) && i5 && i6 && i7) {
							num = 5;
						} else {
							if ((!i1) && i2 && (!i3) && i4 && i5 && i6 && (!i7)) {
								num = 4;
							} else {
								if ((!i1) && (!i2) && i3 && i4 && i5 && i6 && i7) {
									num = 3;
								} else {
									if (i1 && (!i2) && i3 && i4 && i5 && (!i6) && i7) {
										num = 2;
									} else {
										if ((!i1) && (!i2) && (!i3) && i4 && (!i5) && i6 && (!i7)) {
											num = 1;
										} else {
											if (i1 && i2 && i3 && i4 && (!i5) && i6 && i7) {
												num = 0;
											} else {
												num=-1;
											}
										}
									}
								}
							}
						}

					}
				}
			}
		}
		PlayerPrefs.SetInt ("Math_torch&matches_" + bu.ToString (), num);
	}
}
