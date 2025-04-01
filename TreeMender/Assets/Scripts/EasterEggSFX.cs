using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

public class EasterEggSFX : MonoBehaviour
{
    [Tooltip("The sound to play when the object is clicked.")]
    public AudioClip clickSound;

    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("No AudioSource attached to the GameObject. Please attach one.");
        }
    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    PlayClickSound();
                }
            }
        }
    }

    void PlayClickSound()
    {
        
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
        else
        {
            Debug.LogWarning("Click Sound not assigned!");
        }
    }
}