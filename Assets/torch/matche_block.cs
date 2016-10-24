using UnityEngine;
using System.Collections;

public class matche_block : MonoBehaviour {

	public GameObject another;
	public int all_matches;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if ( ((PlayerPrefs.GetInt ("Math_torch&matches_allmatches")>0) && (all_matches==1))||( (all_matches==-1) && (PlayerPrefs.GetInt ("Math_torch&matches_maxmatches")>0))) {
			another.SetActive (true);
			PlayerPrefs.SetInt ("Math_torch&matches_allmatches", PlayerPrefs.GetInt ("Math_torch&matches_allmatches") - all_matches);
			if( (all_matches==-1) && (PlayerPrefs.GetInt ("Math_torch&matches_maxmatches")>0))
			{
				PlayerPrefs.SetInt ("Math_torch&matches_maxmatches",PlayerPrefs.GetInt ("Math_torch&matches_maxmatches")-1);
			}
			this.gameObject.SetActive (false);
		}
	}
}
