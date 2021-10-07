using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officeScript_1_2_3 : MonoBehaviour {

	[Header("Office variables")]
	public Transform officeTransform;
	public float moveSpeed;
	public int[] camLimit;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Joystick1Button11) || Input.GetKey(KeyCode.LeftArrow))
		{
			officeTransform.localPosition = new Vector3(officeTransform.localPosition.x + moveSpeed, officeTransform.localPosition.y, officeTransform.localPosition.z);
		}
		else if (Input.GetKey(KeyCode.Joystick1Button9) || Input.GetKey(KeyCode.RightArrow))
		{
			officeTransform.localPosition = new Vector3(officeTransform.localPosition.x - moveSpeed, officeTransform.localPosition.y, officeTransform.localPosition.z);
		}

		if (officeTransform.localPosition.x < camLimit[0]) officeTransform.localPosition = new Vector3(camLimit[0], officeTransform.localPosition.y, officeTransform.localPosition.z);
		if (officeTransform.localPosition.x > camLimit[1]) officeTransform.localPosition = new Vector3(camLimit[1], officeTransform.localPosition.y, officeTransform.localPosition.z);
	}
}
