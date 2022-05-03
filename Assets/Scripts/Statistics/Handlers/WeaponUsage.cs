using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class WeaponUsage : StatisticsEntity<WeaponUsageModel>
{  
    public IEnumerator SendRequest(WeaponUsageModel model)
    {
        using (WebRequest request = WebRequest.PostString($"{Host}/{WeaponUsagePath}", model.ToString()))
        {
            yield return www.SendWebRequest();

            
            // if (www.result != UnityWebRequest.Result.Success)
            // {
            //     Debug.Log(www.error);
            // }
            // else
            // {
            //     Debug.Log("Form upload complete!");
            // }
        }
    }
}
