using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

        public void EndGame()
        {
            Application.Quit();
        }

        public void ChangeScene(string scenename)
        {
        #pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(scenename);
        #pragma warning restore CS0618 // Type or member is obsolete
        }
    
}
