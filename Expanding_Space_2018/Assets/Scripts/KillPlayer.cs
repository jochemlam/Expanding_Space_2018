using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

    public static bool PlayerDead;

    private void Start()
    {
        PlayerDead = false;
    }
    private void Update()
    {
        Debug.Log(KillPlayer.PlayerDead);
        if (PlayerDead == true)
        {
            //Debug.Log("sdfg");

           GameOverScreen.acquiredScore = ScoreScript.ScoreValue;
            Debug.Log("sdfg" + ScoreScript.ScoreValue);

            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

#pragma warning disable CS0618 // Type or member is obsolete
            SceneManager.UnloadScene("Main");
#pragma warning restore CS0618 // Type or member is obsolete

            
        }
    }
    
 }
