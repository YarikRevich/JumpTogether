using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour
{
    public Toggle toggle;
    private Sprite spriteForOn;
    private Sprite spriteForOff;


    // Start is called before the first frame update
    void Awake()
    {
        spriteForOn = Resources.Load<Sprite>("Sprites/UI/greencheckboxon.png");
        spriteForOff = Resources.Load<Sprite>("Sprites/UI/greencheckboxoff.png");
        toggle.onValueChanged.AddListener(OnSwitch);
    }

    public void OnSwitch(bool value)
    {
        if (value)
        {
            toggle.image.sprite = spriteForOn;
        }
        else
        {
            toggle.image.sprite = spriteForOff;
        }
    }
}
