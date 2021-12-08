using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
	public float xSpread;
	public float zSpread;
	public float yOffset;
	public Transform centerPoint;

	public float rotSpeed;
	

	float timer = 0;

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime * rotSpeed;
		Rotate();
		transform.RotateAround(transform.position, transform.up, Time.deltaTime * 90f);

	}

	void Rotate()
	{

		float x = Mathf.Cos(timer) * xSpread;
		float z = Mathf.Sin(timer) * zSpread;
		Vector3 pos = new Vector3(x, yOffset, z);
		transform.position = pos + centerPoint.position;

	}
}
