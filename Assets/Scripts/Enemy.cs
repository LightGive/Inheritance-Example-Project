using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseStatus
{
	[SerializeField]
	protected int m_score;
	[SerializeField]
	private float m_shotInterval;
	[SerializeField]
	protected AnimationCurve m_animCurve;

	private bool isActive;
	private Vector3 startPos;
	private Vector3 endPos;
	private float m_timeCnt;
	private float m_intervalTimeCnt;

	private void Start()
	{
		isActive = false;
		startPos = transform.position;
		endPos = transform.position + SceneMain.Instance.positionOffset;
	}

	private void Update()
	{
		if(!isActive)
		{
			m_timeCnt += Time.deltaTime;
			transform.position = Vector3.Lerp(startPos, endPos, m_animCurve.Evaluate(Mathf.Clamp01(m_timeCnt / m_moveSpeed)));
			if (m_timeCnt > m_moveSpeed)
				isActive = true;
		}
		else
		{
			m_intervalTimeCnt += Time.deltaTime;

		}
	}

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
