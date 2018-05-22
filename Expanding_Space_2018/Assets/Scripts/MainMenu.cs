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

        if (scenename != "Main")
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(scenename);
#pragma warning restore CS0618 // Type or member is obsolete
        } else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel("Main");
#pragma warning restore CS0618 // Type or member is obsolete
        }

      }




}
