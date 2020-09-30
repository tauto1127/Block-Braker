using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private AudioClip breaksSound;
    private void OnCollisionEnter2D(Collision2D other)
    {
        AudioSource.PlayClipAtPoint(breaksSound, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
