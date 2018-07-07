using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseStatus
{
	private void OnTriggerEnter2D(Collider2D _col)
	{
		if(_col.tag == "PlayerBullet")
		{
			var bullet = _col.gameObject.GetComponent<BulletBase>();
			base.Damage(bullet.DamageValue);
		}
	}
}
