using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour
{
    [SerializeField] soundEffects finishExplosion;
    ParticleSystem explosionParticles;
    void Start()
    {
        explosionParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void FinishExplosion()
    {
        StartCoroutine(FinishExplosionCoorutine());
    }

    IEnumerator FinishExplosionCoorutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        finishExplosion.FinishExplosion();
        explosionParticles.Play();
 
    }

}

