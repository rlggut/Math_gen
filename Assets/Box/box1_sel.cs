using UnityEngine;
using System.Collections;

public class box1_sel : MonoBehaviour {

	public GameObject p1, p2, p3, p4, p5, p6, p7, p8, p9,o1,o2,o3,o4,o5,o6,o7,o8,o9;
	public int num;
	public GameObject anim,ok,sel;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseDown()
	{
		if (num > 4) {
			o1.SetActive(false);
			o2.SetActive(false);
			o3.SetActive(false);
			o4.SetActive(false);
			if(num>7)
			{
				o7.SetActive(false);
				o6.SetActive(false);
				o5.SetActive(false);
				if(num==8) o9.SetActive(false);
				if(num==9) o8.SetActive(false);
			}
			else
			{
				o8.SetActive(false);
				o9.SetActive(false);
				if(num==5)
				{
					o6.SetActive(false);
					o7.SetActive(false);
				}
				if(num==6)
				{
					o5.SetActive(false);
					o7.SetActive(false);
				}
				if(num==7)
				{
					o6.SetActive(false);
					o5.SetActive(false);
				}
			}
		} else {
			o5.SetActive(false);
			o6.SetActive(false);
			o7.SetActive(false);
			o8.SetActive(false);
			o9.SetActive(false);
			if(num>2)
			{
				o1.SetActive(false);
				o2.SetActive(false);
				if(num==3) o4.SetActive(false);
				if(num==4) o3.SetActive(false);
			}
			else
			{
				o3.SetActive(false);
				o4.SetActive(false);
				if(num==1) o2.SetActive(false);
				if(num==2) o1.SetActive(false);
			}
		}
		if (num <= 8) p9.SetActive (false);
		if (num <= 7) p8.SetActive (false);
		if (num <= 6) p7.SetActive (false);
		if (num <= 5) p6.SetActive (false);
		if (num <= 4) p5.SetActive (false);
		if (num <= 3) p4.SetActive (false);
		if (num <= 2) p3.SetActive (false);
		if (num <= 1) p2.SetActive (false);
		anim.SetActive (true);
		sel.SetActive (true);
		PlayerPrefs.SetInt ("math_first_box_sel",num);
		if (num == PlayerPrefs.GetInt ("math_first_box_answ")) {
			ok.SetActive(true);
		}
	}
}
