using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    [SerializeField] int timeToDelay = 3;

    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            LoadNextScene();
        }
    }


    public void LoadNextScene()
    {
        StartCoroutine(DelayBelowLoad());
    }

    IEnumerator DelayBelowLoad()
    {
        yield return new WaitForSeconds(timeToDelay);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

}
