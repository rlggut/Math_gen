using UnityEngine;
using System.Collections;

public class Shuflle : MonoBehaviour {
	public GameObject p1, p2, p3;
	private Vector3 offset1,offset2,offset3;
	private int r,i;

	// Use this for initialization
	void Start () {
		for (i=0; i<Random.Range(10,50); i++) {
			offset1 = p1.transform.position;
			offset2 = p2.transform.position;
			offset3 = p3.transform.position;
			r = Random.Range (1, 3);
			if (r == 2) {
				p1.transform.position = offset2;
				p2.transform.position = offset1;
			}
			if (r == 3) {
				p1.transform.position = offset3;
				p3.transform.position = offset1;
			}
			offset1 = p1.transform.position;
			offset2 = p2.transform.position;
			offset3 = p3.transform.position;
			r = Random.Range (1, 3);
			if (r == 1) {
				p3.transform.position = offset1;
				p1.transform.position = offset3;
			}
			if (r == 2) {
				p2.transform.position = offset3;
				p3.transform.position = offset2;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
