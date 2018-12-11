using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startProject : MonoBehaviour {

    public void SceneLoader(int indexOfScene)
    {
        SceneManager.LoadScene(indexOfScene);
    }
}
// comment