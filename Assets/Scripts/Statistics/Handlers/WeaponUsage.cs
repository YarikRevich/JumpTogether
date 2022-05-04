using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;

public class WeaponUsage : StatisticsEntity<WeaponUsageModel>
{  
    public IEnumerator SendRequest(WeaponUsageModel model)
    {
        using (UnityWebRequest request = WebRequest.PostString($"{Statistics.Constants.API.Host}/{Statistics.Constants.API.WeaponUsagePath}", model.ToString()))
        {
            yield return request.SendWebRequest();
            // #if UNITY_EDITOR
            // // switch (request.ResponseCode)
            // // {
                
            // // }
            // #endif

                // if (www.result != UnityWebRequest.Result.Success)
            
            
            // 
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
