using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elements1scene2 : MonoBehaviour
{
    [SerializeField] GameObject Answer1;
    [SerializeField] GameObject Answer2;
    [SerializeField] GameObject Answer3;
    [SerializeField] GameObject Answer4;
    [SerializeField] GameObject Answer5;
    [SerializeField] GameObject Answer6;

    [SerializeField] GameObject destroyAnswerEffectBig;
    [SerializeField] GameObject destroyAnswerEffectSmall;
    [SerializeField] Transform particleSpawnPlace;
    [SerializeField] GameObject EthernalLines;
    [SerializeField] GameObject envronmentaleffect;
    [SerializeField] GameObject nextElements;

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
        Instantiate(destroyAnswerEffectSmall, Answer5.transform.position , transform.rotation);
        Instantiate(destroyAnswerEffectSmall, Answer6.transform.position , transform.rotation);

        Destroy (Answer1);
        Destroy (Answer2);
        Destroy (Answer3);
        Destroy (Answer4);
        Destroy (Answer5);
        Destroy (Answer6);
        Instantiate(envronmentaleffect, EthernalLines.transform.position, transform.rotation );
        Destroy (EthernalLines);
        nextElements.SetActive(true);
        //Instantiate(Elements 2, particleSpawnPlace.position , transform.rotation);
    }
}

