using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gumpickup : MonoBehaviour
{
    AudioSource audioSource;
    public Animator kamim;
    private bool isgumming;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        kamim.SetBool("isGumming", isgumming);
    }

    void OnCollisionEnter(Collision collision)
    {
        isgumming = true;
       
            audioSource.Play();
    }
}
