using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseParticles : MonoBehaviour
{
    [SerializeField] soundEffects explosionSound;
    ParticleSystem explosionParticles;
    void Start()
    {
        explosionParticles = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void StartExplosion()
    {
        StartCoroutine(StartExplosionCoorutine());
    }

    IEnumerator StartExplosionCoorutine()
    {
        explosionSound.ExplodeEffect();
        yield return new WaitForSecondsRealtime(0.5f);
        explosionParticles.Play();
        yield return new WaitForSecondsRealtime(0.83f);
        explosionParticles.Pause();
    }

}
