using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ElementsAnimals : MonoBehaviour
{
    [SerializeField] GameObject Answer1;
    [SerializeField] GameObject Answer2;
    [SerializeField] GameObject Answer3;
    [SerializeField] GameObject Answer4;
    [SerializeField] GameObject Answer5;
    [SerializeField] GameObject destroyAnswerEffectBig;
    [SerializeField] GameObject destroyAnswerEffectSmall;
    [SerializeField] Transform particleSpawnPlace;
    //[SerializeField] Transform particleSpawnPlace;
    //[SerializeField] GameObject EthernalLines;
    //[SerializeField] GameObject Rain;
    //[SerializeField] GameObject Elements3;
    //[SerializeField] LevelLoader levelLoader;
    //[SerializeField] Animator transition;
    int sceneToLoad = +1;
    
    void Update()
    {
      //  foreach (Transform child in transform)
       // {
     //       //child.position += Vector3.up * 10.0f;
     //       child.transform.Rotate(1,1,1);
      //  }
    }

    public void RightAnswer()
    {
        
        Instantiate(destroyAnswerEffectSmall, Answer1.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer2.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer3.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer4.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer5.transform.position , transform.rotation);
        Destroy (Answer1);
        Destroy (Answer2);
        Destroy (Answer3);
        Destroy (Answer4);
        Destroy (Answer5);
        Instantiate(destroyAnswerEffectBig, particleSpawnPlace.position , transform.rotation);
        //levelLoader.LoadNextLevel();
        //StartCoroutine(LoadSceneAsynchro()); 
        //LoadNextLevel();       
        //SceneManager.LoadScene("Scene 2");
        //SceneManager.LoadSceneAsync(sceneToLoad);
        //Instantiate(Elements 2, particleSpawnPlace.position , transform.rotation);
    }

    private static IEnumerator LoadSceneAsynchro()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

        while (!asyncLoad.isDone)
        {
            
            yield return null;
        }
    }

    

}
