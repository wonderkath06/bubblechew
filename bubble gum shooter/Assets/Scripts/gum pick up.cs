using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class gumpickup : MonoBehaviour
{
    AudioSource audioSource;
    public Animator kamim;
    public bool isgumming = false;
    SerializeField Gum;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        kamim.SetBool("isGumming", isgumming);
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        
        if (collision.gameObject.tag == "Gum")
            isgumming = true;   
                    
        audioSource.Play();
    }
}
