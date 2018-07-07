using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseStatus
{

	// Use this for initialization
	void Start () {
		
	}
	
	void Update ()
	{
		var vec = new Vector2(
			Input.GetAxisRaw("Horizontal"), 
			Input.GetAxisRaw("Vertical"));

		base.Move(vec);
	}
}
