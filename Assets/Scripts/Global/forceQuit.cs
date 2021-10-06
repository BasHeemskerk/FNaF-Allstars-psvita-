using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class forceQuit : MonoBehaviour {

	void Update () {
		if ((Input.GetKey(KeyCode.JoystickButton6)) && Input.GetKey(KeyCode.JoystickButton7) || (Input.GetKey(KeyCode.Q))){
			Resources.UnloadUnusedAssets();
			SceneManager.LoadSceneAsync("Launcher");
        }
	}
}
