using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mask_2 : MonoBehaviour {

	public Animator maskAnim;
    public GameObject maskGameObject;
    public GameObject maskBobGameObject;
	public AudioSource[] sfx;
    public float animTime = 0.2f;
	public bool isOn;
	string status = "nothing";

	IEnumerator putOn()
    {
		if (status == "animating")
        {
			yield break;
        }
        else
        {
            status = "animating";
            maskGameObject.SetActive(true);
            yield return new WaitForSeconds(0.01f);
            maskAnim.SetTrigger("putOn");
            sfx[0].Play();
            yield return new WaitForSeconds(animTime);
            sfx[1].Play();
            isOn = true;
            maskBobGameObject.SetActive(true);
            maskGameObject.SetActive(false);
            status = "nothing";
            yield break;
        }
    }

	IEnumerator takeOff()
    {
		if (status == "animating")
        {
			yield break;
        }
        else
        {
            status = "animating";
            maskBobGameObject.SetActive(false);
            maskGameObject.SetActive(true);
            yield return new WaitForSeconds(0.01f);
            maskAnim.SetTrigger("takeOff");
            sfx[2].Play();
            yield return new WaitForSeconds(animTime);
            sfx[1].Stop();
            isOn = false;
            maskGameObject.SetActive(false);
            status = "nothing";
            yield break;
        }
    }

    public void mask()
    {
        if (!isOn)
        {
            StartCoroutine(putOn());
        }
        else if (isOn){
            StartCoroutine(takeOff());
        }
    }

	void Update () {
		if (Input.GetKeyDown(KeyCode.JoystickButton4) || Input.GetKeyDown(KeyCode.L))
        {
            mask();
        }
	}
}
