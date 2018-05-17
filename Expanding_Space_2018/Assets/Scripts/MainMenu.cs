using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public void EndGame()
    {
        Application.Quit();
    }

    public void ChangeScene (string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
