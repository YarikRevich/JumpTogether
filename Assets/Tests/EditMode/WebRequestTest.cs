using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.Networking;

public class WebRequestTest
{
    [Test]
    public void WebRequestTestStatusCodes()
    {
        Assert.AreEqual(WebRequest.Ok, 200);
        Assert.AreEqual(WebRequest.NotFound, 404);
        Assert.AreEqual(WebRequest.InternalServerError, 500);
    }

    [UnityTest]
    public IEnumerator WebRequestTestPostWithEnumeratorPass()
    {
        using (UnityWebRequest request = WebRequest.PostString("https://postman-echo.com/post", ""))
        {
            yield return request.SendWebRequest();
            Assert.AreEqual(request.responseCode, WebRequest.Ok);
            Assert.IsTrue(request.isDone);
        }
    }
}
