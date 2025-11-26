using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public AudioClip hitsound;
    public AudioSource audioSource;
    public float restartDelay = 2f; 
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = hitsound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            
            audioSource.Play();
            StartCoroutine(RestartWithDelay());
        }
        if (collision.gameObject.tag == "Finish")
        {
            
            audioSource.Stop();
        }
    }

    IEnumerator RestartWithDelay()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(restartDelay);

        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
