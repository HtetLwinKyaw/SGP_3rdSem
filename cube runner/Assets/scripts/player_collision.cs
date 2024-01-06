using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class player_collision : MonoBehaviour
{
    public playerscript playerscript;
    public scoretext score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource gameendaudioSource;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            gameendaudioSource.Play();
            gameController.GameOver();
            playerscript.enabled = false;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectables")
        {
            audioSource.Play();
            score.addscore(1);
            Destroy(other.gameObject);
        }
    }
}
