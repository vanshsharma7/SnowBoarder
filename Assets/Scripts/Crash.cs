using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float delay2=0.3f;
    [SerializeField] ParticleSystem crasheffect;
    [SerializeField] AudioClip crashSFX;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            FindObjectOfType<PlayerController>().DisableControls();
            crasheffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("RestartScene",delay2);
        }
    }
    void RestartScene(){
        SceneManager.LoadScene(0);    
    }
}
