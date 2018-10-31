using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SounGeneratorScript : MonoBehaviour {

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
		
	}

    public void PlaySound()
    {
        audioSource.Play();
    }
}
