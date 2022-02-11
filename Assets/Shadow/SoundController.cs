using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AudioSource"))
        {
            _audioSource = other.GetComponent<AudioSource>();
            if(_audioSource.isPlaying == false)
            {
                _audioSource.Play();
                Debug.Log("Sound Play");
            }
            
        }
    }
}
