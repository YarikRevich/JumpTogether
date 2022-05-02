using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public Text displayText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    public void Update ()
    {
        int fps = (int)(Time.frameCount / Time.time);
        displayText.text = $"FPS: {fps}";
    }
}
