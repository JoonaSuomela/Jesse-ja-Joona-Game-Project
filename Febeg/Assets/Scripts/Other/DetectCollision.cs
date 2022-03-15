using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public GameObject deathScreen;

    void Start()
    {
        deathScreen.SetActive(false);
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.layer == 9) {
            deathScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
}
