using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FishButton : MonoBehaviour
{

    public void fishSceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
