using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public Animator Animation;
    void Update () {

    }

    public void LoadNextLevel () {
        StartCoroutine (LoadLevel ());
    }

    IEnumerator LoadLevel () {
        Animation.SetTrigger ("Start");
        yield return new WaitForSeconds (1);

        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

    }
}