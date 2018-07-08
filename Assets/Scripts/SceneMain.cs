using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMain : SingletonMonoBehaviour<SceneMain>
{
	[SerializeField]
	private Enemy[] m_enemys;
	[SerializeField]
	private EnemyPos[] m_enemyPos;
	[SerializeField]
	private Text m_textScoreValue;
	[SerializeField]
	private Text m_textWaveValue;
	[SerializeField]
	private int m_generateNo;

	private bool m_isGenerate;
	private int m_score;
	private int m_wave;
	private List<Enemy> m_generateEnemyList;

	public Vector3 positionOffset;

	[System.Serializable]
	public class EnemyPos
	{
		public Vector2[] pos;
	}

	void Start ()
	{
		m_score = 0;
		m_wave = 0;
		m_isGenerate = false;
		GenerateEnemy();
		AddScore(0);
	}
	
	void Update ()
	{
		CheckEnemy();
	}

	void CheckEnemy()
	{
		for (int i = 0; i < m_generateEnemyList.Count;i++)
		{
			if (m_generateEnemyList[i] != null)
				return;
		}
		GenerateEnemy();
	}

	void GenerateEnemy()
	{
		Debug.Log("生成");
		if (m_isGenerate)
			return;

		m_isGenerate = true;
		var enemyIdx = Random.Range(0, m_enemys.Length);
		var randomIdx = Random.Range(0, m_enemyPos.Length);
		StartCoroutine(_GenerateEnemy(enemyIdx, randomIdx));
	}

	private IEnumerator _GenerateEnemy(int _enemyIdx,int _posIdx)
	{
		m_generateEnemyList = new List<Enemy>(); 
		for (int i = 0; i < m_enemyPos[_posIdx].pos.Length; i++)
		{
			yield return new WaitForSeconds(0.1f);
			var pos = m_enemyPos[_posIdx].pos[i];
			var enemy = Instantiate(m_enemys[_enemyIdx], pos, Quaternion.identity);
			m_generateEnemyList.Add(enemy);
		}
		m_isGenerate = false;
		m_wave++;
		m_textWaveValue.text = m_wave.ToString("00");
	}


	public void AddScore(int _addScore)
	{
		m_score += _addScore;
		m_textScoreValue.text = m_score.ToString("00000");
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.white;
		for (int i = 0; i < m_enemyPos[m_generateNo].pos.Length; i++)
		{
			Gizmos.DrawWireSphere(m_enemyPos[m_generateNo].pos[i] + new Vector2(positionOffset.x,positionOffset.y), 0.1f);
		}
	}
}
