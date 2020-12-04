using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundB : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip[] soundClip;
    // 0 - Shooting
    // 1 - Explosion

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TriggerExplosion();
        }
    }
    void TriggerExplosion()
    {
        audioSource.PlayOneShot(soundClip[1]);

        audioSource.panStereo = 0;
        audioSource.panStereo = -1;
        audioSource.panStereo = 1;
    }


    void FireBullet()
    {
        // Code that fires bullet
        audioSource.PlayOneShot(shooting);
    }
}
