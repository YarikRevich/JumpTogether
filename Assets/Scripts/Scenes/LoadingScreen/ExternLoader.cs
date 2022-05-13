using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExternLoader : MonoBehaviour
{
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GameObject gameObjectToHide;
    [SerializeField] private Scenes.Constants.Scene sceneName;

    public void LoadScene()
    {
        StartCoroutine(LoadAsynchronously());
    }

    private IEnumerator LoadAsynchronously()
    {
        gameObjectToHide.SetActive(false);
        loadingScreen.SetActive(true);

        var operation = SceneManager.LoadSceneAsync((int)sceneName);
        while (!operation.isDone)
        {
            float progess = Mathf.Clamp01(operation.progress / .9f);
            yield return null;
        }
        loadingScreen.SetActive(false);
    }
}
