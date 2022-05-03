using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public Text displayText;

    private float deltaTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        displayText.text = Mathf.Ceil(fps).ToString();
        // Debug.Log($"{Time.frameCount}");
        // int fps = (int)(Time.frameCount / Time.time);
        // displayText.text = $"FPS: {fps}";
    }

    void OnApplicationQuit()
    {
        displayText.text = "";
    }
}
