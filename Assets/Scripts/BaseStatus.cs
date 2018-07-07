using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatus : MonoBehaviour
{
	[SerializeField]
	private int m_maxHp;
	[SerializeField]
	private float m_moveSpeed;

	private int m_hp;

	public int hp
	{
		get { return m_hp; }
		set { m_hp = Mathf.Clamp(value, 0, m_maxHp); }
	}

	void Start ()
	{
		
	}
	
	void Update ()
	{

	}

	public void Damage(int _damageVal)
	{

	}

	public void Move(Vector2 _vec)
	{
		transform.position += new Vector3(_vec.x, _vec.y, 0.0f) * m_moveSpeed * Time.deltaTime;
	}
}
