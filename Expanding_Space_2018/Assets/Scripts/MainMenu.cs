using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
        
    public void EndGame()
        {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_WEBPLAYER
                 Application.OpenURL(webplayerQuitURL);
        #else
                 Application.Quit();
        #endif
        }

    public void ChangeScene(string scenename)
        {

        if (scenename == "Main")
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel("Main");
#pragma warning restore CS0618 // Type or member is obsolete
            KillPlayer.PlayerDead = false;
            ScoreScript.ScoreValue = 0;

        } else if (scenename == "GameOver")
        {
            KillPlayer.PlayerDead = true;
        }

        else
        {
        #pragma warning disable CS0618 // Type or member is obsolete            
            Application.LoadLevel(scenename);
            ScoreScript.ScoreValue = 0;
#pragma warning restore CS0618 // Type or member is obsolete
        }

      }




}
