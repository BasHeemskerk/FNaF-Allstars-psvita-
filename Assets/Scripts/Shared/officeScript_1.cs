using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officeScript_1 : MonoBehaviour {

	[Header("Office variables")]
	public Transform officeTransform;
	public int[] camLimit;

	void Start () {
		
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.Joystick1Button11) || Input.GetKey(KeyCode.LeftArrow))
		{
			officeTransform.localPosition = new Vector3(officeTransform.localPosition.x + 8f, officeTransform.localPosition.y, officeTransform.localPosition.z);
		}
		else if (Input.GetKey(KeyCode.Joystick1Button9) || Input.GetKey(KeyCode.RightArrow))
		{
			officeTransform.localPosition = new Vector3(officeTransform.localPosition.x - 8f, officeTransform.localPosition.y, officeTransform.localPosition.z);
		}

		if (officeTransform.localPosition.x < -200) officeTransform.localPosition = new Vector3(-200, officeTransform.localPosition.y, officeTransform.localPosition.z);
		if (officeTransform.localPosition.x > 200) officeTransform.localPosition = new Vector3(200, officeTransform.localPosition.y, officeTransform.localPosition.z);
	}
}
