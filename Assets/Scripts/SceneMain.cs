﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class SceneMain : MonoBehaviour
{
	[SerializeField]
	private Enemy[] m_enemys;
	[SerializeField]
	private Text m_textScoreValue;
	[SerializeField]
	private Text m_textWaveValue;
	private int m_wave;
	private List<Enemy> m_generateEnemyList;

	void Start ()
	{
		m_wave = 0;
	}
	
	void Update ()
	{
		
	}

	void CheckEnemy()
	{
		for (int i = 0; i < m_generateEnemyList.Count;i++)
		{
			if (m_generateEnemyList[i] != null)
				return;
		}
		Invoke("GenerateEnemy", 1.0f);
	}

	void GenerateEnemy()
	{

	}
}