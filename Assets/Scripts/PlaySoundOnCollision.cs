using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{
    AudioSource aud;
    public AudioClip clip;
    public float volume = .7f;
    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col){
        if (aud) {
            aud.PlayOneShot(clip, volume);
        }
    }
}
