using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private float _timeToWait = 4;
    private int _currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        _currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (_currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(_timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        var nextSceneIndex = _currentSceneIndex + 1;

        if (SceneManager.sceneCountInBuildSettings <= nextSceneIndex)
        {
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }
}
