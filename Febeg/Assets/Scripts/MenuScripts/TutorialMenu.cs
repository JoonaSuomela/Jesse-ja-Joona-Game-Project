using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenu : MonoBehaviour
{
    public void Yes () {
        SceneManager.LoadScene("Tutorial");
    }

    public void No () {
        SceneManager.LoadScene("Quest1");
    }
}
