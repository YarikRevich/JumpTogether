using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using NLogger = NLog.Logger;
using NLogManager = NLog.LogManager;

public class WeaponUsage : StatisticsEntity<WeaponUsageModel>
{
    private static NLogger logger =
            NLogManager.GetCurrentClassLogger();

    public IEnumerator SendRequest(WeaponUsageModel model)
    {
        string url = URLCreator.Parse(
            Statistics.Constants.API.Scheme,
            Statistics.Constants.API.Host,
            new string[]{Statistics.Constants.API.WeaponUsagePath}
        );
        string data = model.ToString();
        using (UnityWebRequest request = WebRequest.PostString(url, data))
        {
            yield return request.SendWebRequest();
        
            // #if UNITY_EDITOR
            // // switch (request.ResponseCode)
            // // {

            // // }
            // #endif
        }
    }
}
