using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour {

	public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.3f;
	void Update () {
		gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);

		gameObject.transform.Translate (Vector3.down * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
	}
}
