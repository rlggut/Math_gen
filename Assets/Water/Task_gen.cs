using UnityEngine;
using System.Collections;

public class Task_gen : MonoBehaviour {

	public GameObject w1,w2,w3,w4,w5,w6,w7;

	public GameObject ch1,ch2,ch3,ch4,ch5,ch6;

	public GameObject Ok;

	private int i,j,k,l,t;
	// Use this for initialization
	void Start () {
		t = -1;
		w1.SetActive (false);
		w2.SetActive (false);
		w3.SetActive (false);
		w4.SetActive (false);
		w5.SetActive (false);
		w6.SetActive (false);
		w7.SetActive (false);



/*		i = Random.Range (3, 5);
		j = i;
		while((j==i)||(i-1==j)) j = Random.Range (1, 5);*/

		i = Random.Range (2, 6);
		k = i;
		while(k==i) k = Random.Range (2, 6);

		if (Mathf.Abs (k - i) == 2) {
			l=Mathf.Max (k, i)+1;
			if (Mathf.Max (k, i) == 3)
				w4.SetActive (true);
			if (Mathf.Max (k, i) == 4)
				w5.SetActive (true);
			if (Mathf.Max (k, i) == 5)
				w6.SetActive (true);
			if (Mathf.Max (k, i) == 6)
				w7.SetActive (true);
		} else {
			l=7;
			w7.SetActive (true);
		}
		j = k;
		while((j==i)||(j==k)||(j==l)) j = Random.Range (1, 6);

/*if (Mathf.Abs (k - i) + Mathf.Max (k, i) >= 4) {
			w7.SetActive (true);
		} else {
			w6.SetActive (true);
		}

		if(Mathf.Max (k, i)-Mathf.Abs (k - i) !=Mathf.Min (k, i)){
			j = Mathf.Max (k, i)-Mathf.Abs (k - i);
		}else{
			if(Mathf.Min (k, i)- Mathf.Abs (k - i)!=0){
				j = Mathf.Min (k, i)- Mathf.Abs (k - i);
			}else{
				j=1;
			}
		}
*/

		if(j==1) ch1.SetActive (true);
		if(j==2) ch2.SetActive (true);
		if(j==3) ch3.SetActive (true);
		if(j==4) ch4.SetActive (true);
		if(j==5) ch5.SetActive (true);
		if(j==6) ch6.SetActive (true);


		if(i==2) w2.SetActive (true);
		if(i==3) w3.SetActive (true);
		if(i==4) w4.SetActive (true);
		if(i==5) w5.SetActive (true);
		if(i==6) w6.SetActive (true);
		if(i==7) w7.SetActive (true);

		if(k==2) w2.SetActive (true);
		if(k==3) w3.SetActive (true);
		if(k==4) w4.SetActive (true);
		if(k==5) w5.SetActive (true);
		if(k==6) w6.SetActive (true);
		if(k==7) w6.SetActive (true);

		/*
		if(i!=6)
		{
			if((i-1)==1) w1.SetActive (true);
			if((i-1)==2) w2.SetActive (true);
			if((i-1)==3) w3.SetActive (true);
			if((i-1)==4) w4.SetActive (true);
			if((i-1)==5) w5.SetActive (true);
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
		if ((j == PlayerPrefs.GetInt ("water1")) ||
			(j == PlayerPrefs.GetInt ("water2")) ||
			(j == PlayerPrefs.GetInt ("water3")) ||
			(j == PlayerPrefs.GetInt ("water4")) ||
			(j == PlayerPrefs.GetInt ("water5")) ||
		    (j == PlayerPrefs.GetInt ("water6")) ||
		    (j == PlayerPrefs.GetInt ("water7"))) {
				Ok.SetActive(true);
				PlayerPrefs.SetInt ("math_logic",1);
				PlayerPrefs.SetInt ("math_num",1);
				PlayerPrefs.SetInt ("selected_water",-1);
				if(t==-1) t=100;
		}
		if (t > 0) t--;
		if (t == 0)
			Application.LoadLevel (Application.loadedLevel);
	}
}