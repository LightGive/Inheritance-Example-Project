using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseStatus
{
	[SerializeField]
	protected int m_score;

	private void OnTriggerEnter2D(Collider2D _col)
	{
		Debug.Log("Trigger");

		if(_col.tag == "PlayerBullet")
		{
			var bullet = _col.gameObject.GetComponent<BulletBase>();
			bullet.DestroyObject();
			base.Damage(bullet.DamageValue);
		}
	}
}
