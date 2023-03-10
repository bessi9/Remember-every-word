using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkScript1 : MonoBehaviour
{
    [SerializeField] Light mainLight;
    [SerializeField] AudioSource musicPlayer;
    [SerializeField] float low = 0.75f;
    [SerializeField] Material otherSkybox;
    [SerializeField] Material arenaMaterialDark;
    [SerializeField] GameObject arena;
    // Start is called before the first frame update
    bool isDarkActivated;
    private void Start() 
    {

        musicPlayer.Play(0);
        isDarkActivated = false;
    }
    public void DarkActivated()
    {
        //musicPlayer.Stop();
        RenderSettings.skybox = otherSkybox;
        arena.GetComponent<MeshRenderer>().material = arenaMaterialDark;
       isDarkActivated = true;
       musicPlayer.pitch = low;
       mainLight.intensity = 0.2f;
       mainLight.color = (Color.white / 2.0f) * Time.deltaTime;
    }

}
