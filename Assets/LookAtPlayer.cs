using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] Transform playerCamera;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(playerCamera);
    }
}
