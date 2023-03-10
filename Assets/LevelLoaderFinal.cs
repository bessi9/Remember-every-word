using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoaderFinal : MonoBehaviour
{
        [SerializeField] float secondsToWaitbeforeLoad = 2f;
public void LoadDogsLevel()
    {
        StartCoroutine(LoadLevelDogs());
    }

    IEnumerator LoadLevelDogs()
    {
        
        yield return new WaitForSeconds(secondsToWaitbeforeLoad);
        SceneManager.LoadScene("Elephants");
    }

    public void LoadCatsLevel()
    {
        StartCoroutine(LoadLevelCats());
    }

    IEnumerator LoadLevelCats()
    {
        
        yield return new WaitForSeconds(secondsToWaitbeforeLoad);
        SceneManager.LoadScene("Cats");
    }

        public void LoadPenguinsLevel()
    {
        StartCoroutine(LoadLevelPenguins());
    }

    IEnumerator LoadLevelPenguins()
    {
        
        yield return new WaitForSeconds(secondsToWaitbeforeLoad);
        SceneManager.LoadScene("Penguins");
    }

            public void LoadWhalesLevel()
    {
        StartCoroutine(LoadLevelWhales());
    }

    IEnumerator LoadLevelWhales()
    {
        
        yield return new WaitForSeconds(secondsToWaitbeforeLoad);
        SceneManager.LoadScene("Whales");
    }
}
