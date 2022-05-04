using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsageModel
{
    public string ToString(){
        return JsonUtility.ToJson(this);
    }
}