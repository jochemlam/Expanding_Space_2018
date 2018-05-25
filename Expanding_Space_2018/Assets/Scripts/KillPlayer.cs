using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

    public static bool PlayerDead = false;

    private void Update()
    {
        
        if (PlayerDead == true)
        {

#pragma warning disable CS0618 // Type or member is obsolete
            SceneManager.UnloadScene("Main");
#pragma warning restore CS0618 // Type or member is obsolete

            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
    
 }
