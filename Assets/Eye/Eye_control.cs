using UnityEngine;
using System.Collections;

public class Eye_control : MonoBehaviour {

	public GameObject point,help,att;

	private float offsetx,offsetz;
	public int t,i,rel;
	private float dx,dz;
	// Use this for initialization
	void Start () {
		offsetx = point.transform.position.x;
		offsetz = point.transform.position.z;

		t = -360;
		rel = 0;
	}
	
	// Update is called once per frame
	void Update () {
/*		if (t == 0) {
			if(((point.transform.position.x==offsetx)&&(point.transform.position.x==offsetx))) rel=-1;
			if((rel==0)&&((point.transform.position.x!=offsetx)||(point.transform.position.x!=offsetx)))
			{
				dx=(offsetx - point.transform.position.x)/10;
				dz=(offsetz - point.transform.position.z)/10;
				rel=10;
			}
			if(rel>0)
			{
				point.transform.position=point.transform.position+new Vector3(dx,0,dz);
				rel--;
			}
		}
		if (rel == -1) {
*/
		if (t >= 0)
			help.SetActive (false);

		att.SetActive (false);

		if((t<1440)&(t>0))point.transform.position=point.transform.position+new Vector3(0.25f*Mathf.Sin((t*2-90)*Mathf.PI/180),0,0);

		if((t<1440)&&(t>1260)) att.SetActive(true);
		if((t<2880)&&(t>1440))point.transform.position=point.transform.position+new Vector3(0,0.25f*Mathf.Sin((t*2-90)*Mathf.PI/180),0);

//		if((t<4320)&&(t>2880))point.transform.position=point.transform.position+new Vector3(0.10f*Mathf.Sin((t*2-90)*Mathf.PI/180),0.10f*Mathf.Cos((t*2-90)*Mathf.PI/180),0);

		if((t<2880)&&(t>2700)) att.SetActive(true);
		if((t<4320)&&(t>2880))point.transform.position=point.transform.position+new Vector3(0.10f*Mathf.Sin((t-90)*Mathf.PI/180),0,0.10f*Mathf.Cos((t*2-0)*Mathf.PI/180));

		t++;
	}
}