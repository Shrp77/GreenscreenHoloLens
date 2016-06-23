﻿using UnityEngine;
using System.Collections;

public class SphereCommand : MonoBehaviour {

	void OnSelect()
	{
		// If the sphere has no Rigidbody component, add one to enable physics.
		if (!this.GetComponent<Rigidbody>())
		{
			var rigidbody = this.gameObject.AddComponent<Rigidbody>();
			rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
		}
	}
}
