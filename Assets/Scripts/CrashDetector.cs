using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    int currentLevel;
    [SerializeField] float loadDelay = 1f;

    private void Start() 
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

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
