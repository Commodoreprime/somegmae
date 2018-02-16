using System.Collections;
using System.Collections.Generic;
using UnityEngine;

if(Input.GetMouseButtonDown(0))
{
	if(Bullet)
	{
		GameObject go = Instantiate(prefabBullet);
		Bullet bu = go.GetComponent<Bullet>();
		if(bu)
		{
			Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			bu.Shoot(rb2D.position, target, DamageType, DamageAmount);
		}
	}
}