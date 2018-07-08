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

	public int DamageValue 	{ get { return m_damageVal; } }
	public float Speed 		{ get { return m_speed; } }


	void Start ()
	{
		
	}
	
	protected virtual void Update ()
	{
		transform.position += new Vector3(m_vec.x, m_vec.y, 0.0f) * m_speed * Time.deltaTime;
	}

	public void ShotBullet(Vector2 _vec)
	{
		m_vec = _vec;
	}

	public void DestroyObject()
	{
		Destroy(this.gameObject);
	}

	private void OnBecameInvisible()
	{
		DestroyObject();
	}
}
