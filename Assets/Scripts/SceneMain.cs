using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneMain : MonoBehaviour
{
	[SerializeField]
	private Enemy[] m_enemys;
	[SerializeField]
	private Text m_textScoreValue;
	[SerializeField]
	private Text m_textWaveValue;
	private int m_wave;

	void Start ()
	{
		m_wave = 0;
	}
	
	void Update ()
	{
		
	}
}
