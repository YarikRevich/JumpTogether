using System.Collections;
using System.Collections.Generic;

public class UsageModel
{
    public string ToString(){
        return JsonUtility.ToJson(this);
    }
}