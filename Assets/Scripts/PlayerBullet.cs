using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : BulletBase
{
	[SerializeField]
	private float m_speed;
	private Vector2 m_vec;
	private bool m_isActive;

	private void Update()
	{
		transform.position += new Vector3(m_vec.x, m_vec.y, 0.0f) * m_speed * Time.deltaTime;
	}
}
