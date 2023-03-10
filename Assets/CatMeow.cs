using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMeow : MonoBehaviour
{
    [SerializeField] AudioClip Meow;
    [SerializeField] AudioSource audioSource;

        public void MeowEffect()
    {
        audioSource.clip = Meow;
        audioSource.Play();
    }
}
