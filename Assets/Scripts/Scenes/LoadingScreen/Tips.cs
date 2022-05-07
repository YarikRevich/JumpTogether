using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tips : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    private List<string> tips = new List<string>();
    // Start is called before the first frame update
    void Awake()
    {
        string[] rawTips = File.ReadAllLines("Assets/Configs/tips.txt");
        foreach (string rawTip in rawTips)
        {
            if (!string.IsNullOrWhiteSpace(rawTip)){
                tips.Add(rawTip);
            }
        }
    }

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(ShowTips());
    }

    public IEnumerator ShowTips()
    {
        while (true)
        {
            displayText.text = tips[Random.Range(0, tips.Count)];
            yield return new WaitForSeconds(6);
        }
    }
}
