using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Version : MonoBehaviour
{
    public Text displayText;

    // Update is called once per frame
    void Awake()
    {
        displayText.text = $"Version: {Application.version}";
    }
}
