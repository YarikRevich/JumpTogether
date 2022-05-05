using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Author : MonoBehaviour
{
    public Text displayText;

    // Update is called once per frame
    void Awake()
    {
        displayText.text = $"Author: {Application.version}";
    }
}
