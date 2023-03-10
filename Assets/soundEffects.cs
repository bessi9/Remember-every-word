using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffects : MonoBehaviour
{
    [SerializeField] AudioClip finishExplosion;
    [SerializeField] AudioClip explodeEffect;
    [SerializeField] AudioClip correctEffect;
    [SerializeField] AudioClip wrongEffect;
    [SerializeField] AudioClip selectEffect;
    [SerializeField] AudioClip hoverEffect;

    private AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void CorrectEffect()
    {
        audioSource.clip = correctEffect;
        audioSource.Play();
    }

    public void SelectEffect()
    {
        audioSource.clip = selectEffect;
        audioSource.Play();
    }

    public void HoverEffect()
    {
        audioSource.clip = hoverEffect;
        audioSource.Play();
    }
    
        public void WrongEffect()
    {
        audioSource.clip = wrongEffect;
        audioSource.Play();
    }

            public void ExplodeEffect()
    {
        audioSource.clip = explodeEffect;
        audioSource.Play();
    }

                public void FinishExplosion()
    {
        audioSource.clip = explodeEffect;
        audioSource.Play();
    }
}
