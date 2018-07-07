using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : BulletBase
{
	private Vector2 m_vec;
	private bool m_isActive;

	public bool isActive
	{
		get { return m_isActive; }
	}

	private void Update()
	{
		if (isActive)
		{
			transform.position += new Vector3(m_vec.x, m_vec.y, 0.0f) * m_speed * Time.deltaTime;
		}
	}
}
