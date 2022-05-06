using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//<summary>
//Component for switch
//</summary>
public class DebugInfoToggle : MonoBehaviour
{
    public Toggle toggle;

    void Awake()
    {
        toggle.onValueChanged.AddListener(delegate {
            OnSwitch(toggle);
        });
    }

    public void OnSwitch(Toggle change)
    {
        if (change.isOn)
        {
            GlobalState.DebugInfo = true;
        }
        else
        {
            GlobalState.DebugInfo = false;
        } 
    }
}
