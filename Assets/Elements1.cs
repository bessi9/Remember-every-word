using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elements1 : MonoBehaviour
{
    [SerializeField] GameObject Answer1;
    [SerializeField] GameObject Answer2;
    [SerializeField] GameObject Answer3;
    [SerializeField] GameObject Answer4;
    [SerializeField] GameObject destroyAnswerEffectBig;
    [SerializeField] GameObject destroyAnswerEffectSmall;
    [SerializeField] Transform particleSpawnPlace;
    [SerializeField] GameObject EthernalLines;
    [SerializeField] GameObject Rain;
    [SerializeField] GameObject Elements2;

    [SerializeField] float RotationSpeed = 1;
    
    void Update()
    {
        foreach (Transform child in transform)
        {
            //child.position += Vector3.up * 10.0f;
            child.transform.Rotate(RotationSpeed,RotationSpeed,RotationSpeed);
        }
    }

    public void RightAnswer()
    {
        //Instantiate(destroyAnswerEffectBig, particleSpawnPlace.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer1.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer2.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer3.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer4.transform.position , transform.rotation);
        Destroy (Answer1);
        Destroy (Answer2);
        Destroy (Answer3);
        Destroy (Answer4);
        Instantiate(Rain, EthernalLines.transform.position, transform.rotation );
        Destroy (EthernalLines);
        Elements2.SetActive(true);
        //Instantiate(Elements 2, particleSpawnPlace.position , transform.rotation);
    }
}

