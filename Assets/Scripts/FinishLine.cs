using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delay1=0.5f;
    [SerializeField] ParticleSystem finisheffect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            finisheffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",delay1);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);            
    }
}
