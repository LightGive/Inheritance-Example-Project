using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBase : MonoBehaviour
{
	[SerializeField]
	private int m_damageVal;
	[SerializeField]
	protected float m_speed;

	public int DamageValue
	{
		get { return m_damageVal; }
	}
	public float Speed
	{
		get { return m_speed; }
	}


	void Start ()
	{
		
	}
	
	void Update ()
	{
		
	}
}
