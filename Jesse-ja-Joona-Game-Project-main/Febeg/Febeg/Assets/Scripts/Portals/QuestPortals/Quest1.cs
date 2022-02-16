using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest1 : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Quest1");
    }
}
