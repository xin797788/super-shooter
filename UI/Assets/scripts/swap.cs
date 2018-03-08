using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour {

	public void GotoPage(string sceneName)
	{
		Application.LoadLevel (sceneName);
	}
}
