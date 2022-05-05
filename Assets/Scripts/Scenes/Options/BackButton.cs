using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private IEnumerator OnClickEnumerator()
    {
        AsyncOperation loadingScene = SceneManager.LoadSceneAsync((int)Scenes.Constants.Scene.MAIN_MENU);
        while (!loadingScene.isDone){
            yield return null;
        }
    }

    public void OnClick()
    {
        StartCoroutine(OnClickEnumerator());
    }
}
