using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradientColor : MonoBehaviour
{
    public GameObject gameObject;

    private Material m_Material;
    private Gradient gradient;

    public Color color1;
    public Color color2;
    public float relativeTime = .25f;

    private GradientColorKey[] colorKey;
    private GradientAlphaKey[] alphaKey;

    void Awake()
    {
        m_Material = gameObject.GetComponent<Renderer>().material;
    }

    void Start()
    {
        gradient = new Gradient();

        colorKey = new GradientColorKey[2];
        colorKey[0].color = color1;
        colorKey[0].time = 0.0f;
        colorKey[1].color = color2;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 0.0f;
        alphaKey[1].time = 1.0f;

        gradient.SetKeys(colorKey, alphaKey);
        
        m_Material.color =  gradient.Evaluate(relativeTime);
    }
}
