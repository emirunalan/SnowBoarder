using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    int currentLevel = SceneManager.GetActiveScene().buildIndex;
    [SerializeField] float loadDelay = 1f;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene",loadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(currentLevel);
    }
}
