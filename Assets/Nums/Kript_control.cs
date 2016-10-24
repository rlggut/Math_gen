using UnityEngine;
using System.Collections;

public class Kript_control : MonoBehaviour {
	public GameObject p1,p2,p3,p4,p5,p6;
	public int num;
	// Use this for initialization
	void Start () {
		if(num>=1) p1.SetActive (false);
		if(num>=2) p2.SetActive (false);
		if(num>=3) p3.SetActive (false);
		if(num>=4) p4.SetActive (false);
		if(num>=5) p5.SetActive (false);
		if(num>=6) p6.SetActive (false);
		if (num > 1) {
			if(num>2)
			{
				if(num>3)
				{
					if(num>4)
					{
						if(num>5)
						{
							if(Random.Range(1,num)==1)
							{
								p1.SetActive(true);
							}
							else
							{
								if(Random.Range(1,num)==1)
								{
									p2.SetActive(true);
								}
								else
								{
									if(Random.Range(1,num)==1)
									{
										p3.SetActive(true);
									}
									else
									{
										if(Random.Range(1,num)==1)
										{
											p4.SetActive(true);
										}
										else
										{
											if(Random.Range(1,num)==1)
											{
												p5.SetActive(true);
											}
											else
												p6.SetActive(true);
										}
									}
								}
							}
						}
						else
						{
							if(Random.Range(1,num)==1)
							{
								p1.SetActive(true);
							}
							else
							{
								if(Random.Range(1,num)==1)
								{
									p2.SetActive(true);
								}
								else
								{
									if(Random.Range(1,num)==1)
									{
										p3.SetActive(true);
									}
									else
									{
										if(Random.Range(1,num)==1)
										{
											p4.SetActive(true);
										}
										else
											p5.SetActive(true);
									}
								}
							}
						}

					}
					else
					{
						if(Random.Range(1,num)==1)
						{
							p1.SetActive(true);
						}
						else
						{
							if(Random.Range(1,num)==1)
							{
								p2.SetActive(true);
							}
							else
							{
								if(Random.Range(1,num)==1)
								{
									p3.SetActive(true);
								}
								else
								{
									p4.SetActive(true);
								}
							}
						}
					}
				}
				else
				{
					if(Random.Range(1,num)==1)
					{
						p1.SetActive(true);
					}
					else
					{
						if(Random.Range(1,num)==1)
						{
							p2.SetActive(true);
						}
						else
							p3.SetActive(true);
					}
				}
			}
			else
			{
				if(Random.Range(1,num)==1)
				{
					p1.SetActive(true);
				}
				else
				{
					p2.SetActive(true);
				}
			}
		} else {
			p1.SetActive(true);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
