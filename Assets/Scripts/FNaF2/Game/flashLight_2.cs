using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashLight_2 : MonoBehaviour {

	public Image _office;
	public Sprite _defaultOfficeSprite;
	public Sprite[] _officeSprites;
	public AudioSource _lightBuzz;

	[Header("for the buttons")]
	public Image _leftButton;
	public Image _rightButton;
	public Sprite[] _leftSprites;
	public Sprite[] _rightSprites;

	[Header("shared office script")]
	public officeScript_1_2_3 _officeScript;

	void leftLightOn()
    {
		_office.sprite = _officeSprites[0];
		_lightBuzz.Play();

		_leftButton.sprite = _leftSprites[1];
	}

	void middleLightOn()
    {
		_office.sprite = _officeSprites[1];
	}

	void rightLightOn()
    {
		_office.sprite = _officeSprites[2];
		_lightBuzz.Play();

		_rightButton.sprite = _rightSprites[1];
	}


	void lightOff()
    {
		_office.sprite = _defaultOfficeSprite;
		_lightBuzz.Pause();

		_leftButton.sprite = _leftSprites[0];
		_rightButton.sprite = _rightSprites[0];
    }


	void useLight () {
		if ((Input.GetKeyDown(KeyCode.JoystickButton0)) || (Input.GetKeyDown(KeyCode.X)))
        {
			if (_officeScript.currentLimit[1] == _officeScript.camLimit[1])
            {
				Debug.Log("Left light on");
				leftLightOn();
            }
			else if (_officeScript.currentLimit[0] == _officeScript.camLimit[0])
			{
				Debug.Log("Right light on");
				rightLightOn();
			}
			else if ((_officeScript.currentLimit[0] > _officeScript.camLimit[0] - 175) && (_officeScript.currentLimit[1] < _officeScript.camLimit[1] + 175))
			{
				Debug.Log("Middle light on");
				middleLightOn();
			}
		}
		else if ((Input.GetKeyUp(KeyCode.JoystickButton0)) || (Input.GetKeyUp(KeyCode.X)))
		{
			lightOff();
		}
	}
	
	void Update () {
		useLight();
	}
}
