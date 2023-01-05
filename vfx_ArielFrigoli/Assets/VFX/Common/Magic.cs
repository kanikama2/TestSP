using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public ParticleSystem toTrigger;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            toTrigger.Play();

        }
    }
}
