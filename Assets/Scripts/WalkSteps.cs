using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSteps : MonoBehaviour
{

    private AudioSource audio;
    public AudioClip Ground, Stairs;
    public LayerMask groundLayer, stairsLayer;
    public Transform checkPoint;


    void Start()
    {
        audio = GetComponent<AudioSource>();

        
    }


    void SoundWalk()
    {
        if(Physics.Raycast(checkPoint.position, Vector3.down, 0.6f, groundLayer))
        {
            audio.PlayOneShot(Ground, 1.5f);
            audio.pitch = Random.Range(0.5f, 1.8f);
        }
        else if (Physics.Raycast(checkPoint.position, Vector3.down, 0.6f, stairsLayer))
        {
            audio.PlayOneShot(Stairs, 1.5f);
            audio.pitch = Random.Range(0.5f, 1.8f);
        }

    }


}