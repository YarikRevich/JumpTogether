using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnClick()
    {
        AsyncOperation loadingScene = SceneManager.LoadSceneAsync("Options");
        while (!loadingScene.isDone){
            yield return null;
        }
    }
}
