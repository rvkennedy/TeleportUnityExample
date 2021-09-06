using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMotion : MonoBehaviour
{
	teleport.Teleport_Controller[]  controllers;
	teleport.Teleport_Head head;
	// Start is called before the first frame update
	void Start()
    {
        controllers=GetComponentsInChildren<teleport.Teleport_Controller>();
		head = GetComponentInChildren<teleport.Teleport_Head>();
	}
	

   Vector2 stick = new Vector2(0,0);
	// Update is called once per frame
	void Update()
	{
		Vector3 forward = head.transform.forward;
		forward.y = 0;
		Vector3 right = head.transform.right;
		right.y = 0;
		float playerMoveMultiplier = 2.0F;
		float sprintMultiplier = 1.0F;
		float moveMod = Time.deltaTime * playerMoveMultiplier * sprintMultiplier;
		stick *= 0.5F;
		foreach (var controller in controllers)
		{
			Vector2 axis = controller.joystick;
			stick += 0.5F * (axis );
		}
		transform.Translate(forward * moveMod * stick.y, Space.World);
		//transform.Translate(right * moveMod * stick.x, Space.World);
		float rotateMod = Time.deltaTime * 150.0F;
		transform.Rotate(0, rotateMod * stick.x, 0, Space.World);
    }
}
