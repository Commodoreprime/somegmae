using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HP_Hit_Counter : MonoBehaviour {
	public class collision;
	private void OnCollisionEnter(Collider col)
	{
		collision += 1;
		if (collision == 10);
			Destroy(col.gameObject);
		}
	}