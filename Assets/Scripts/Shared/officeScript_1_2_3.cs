using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class officeScript_1_2_3 : MonoBehaviour {

	[Header("Office variables")]
	public Transform officeTransform;
	public float moveSpeed;
	public int[] camLimit;

	[Header("fnaf 3 only")]
	public bool fnaf3;
	public int[] currentLimit;
	public GameObject consoleButton;
	public GameObject cameraButton;

	void _fnaf3()
    {
		if (currentLimit[1] == camLimit[1])
        {
			consoleButton.SetActive(true);
        }
        else
        {
			consoleButton.SetActive(false);
        }

		if (currentLimit[0] == camLimit[0])
		{
			cameraButton.SetActive(true);
		}
		else
		{
			cameraButton.SetActive(false);
		}
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

		if (fnaf3)
        {
			currentLimit[0] = (int)officeTransform.localPosition.x;
			currentLimit[1] = (int)officeTransform.localPosition.x;
			_fnaf3();
        }
	}
}
