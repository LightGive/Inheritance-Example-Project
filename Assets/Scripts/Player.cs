using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseStatus
{
	void Start ()
	{
		
	}
	
	void Update ()
	{
		var vec = new Vector2(
			Input.GetAxisRaw("Horizontal"), 
			Input.GetAxisRaw("Vertical"));

		base.Move(vec);
	}

	private void OnTriggerEnter2D(Collider2D _col)
	{
		//if(_col.tag == "EnemyBullet")
	}
}
