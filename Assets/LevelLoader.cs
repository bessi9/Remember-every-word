using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
        [SerializeField] Animator transition;
        [SerializeField] float secondsToWaitbeforeLoad = 2f;
public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(secondsToWaitbeforeLoad);
        SceneManager.LoadScene(levelIndex);
    }
}
