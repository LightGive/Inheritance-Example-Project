using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : MonoBehaviour
{
	[SerializeField]
	private int m_damageVal;
	[SerializeField]
	protected float m_speed;
	
	private Vector2 m_vec;
	private bool m_isActive;

	public int DamageValue 	{ get { return m_damageVal; } }
	public float Speed 		{ get { return m_speed; } }
	public bool isActive
	{
		get { return m_isActive; }
		set { m_isActive = value; }
	}

	void Start ()
	{
		
	}
	
	protected virtual void Update ()
	{
		if (isActive)
		{
			transform.position += new Vector3(m_vec.x, m_vec.y, 0.0f) * m_speed * Time.deltaTime;
		}
	}

	public void ShotBullet(Vector2 _vec)
	{
		m_vec = _vec;
		isActive = true;
	}

	public void DestroyObject()
	{
		Destroy(this.gameObject);
	}
}
