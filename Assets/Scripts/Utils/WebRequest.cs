using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;

public static class WebRequest
{
    public const int
        Ok = 200,
        NotFound = 404,
        InternalServerError = 500;

    private static UnityWebRequest Base;

    public static UnityWebRequest PostString(string url, string data)
    {
        var request = new UnityWebRequest(url, "POST");
        byte[] bodyRaw = Encoding.UTF8.GetBytes(data);
        request.uploadHandler = (UploadHandler)new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        return request;
    }
}