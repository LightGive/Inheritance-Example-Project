using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseStatus
{
	[SerializeField]
	private float maxWidth;
	[SerializeField]
	private float maxHeight;

	void Start ()
	{
		
	}
	
	void Update ()
	{
		var vec = new Vector2(
			Input.GetAxisRaw("Horizontal"), 
			Input.GetAxisRaw("Vertical"));

		if ((transform.position.x > maxWidth && vec.x > 0.0f) || (transform.position.x < -maxWidth && vec.x < 0.0f))
			vec.x = 0.0f;
		if ((transform.position.y > maxHeight && vec.y > 0.0f) || (transform.position.y < -maxHeight && vec.y < 0.0f))
			vec.y = 0.0f;

		base.Move(vec);

		if(Input.GetKeyDown(KeyCode.Z))
		{
			ShotBullet(new Vector2(0.0f, 1.0f));
		}
	}

	private void OnTriggerEnter2D(Collider2D _col)
	{
		//if(_col.tag == "EnemyBullet")
	}
}
