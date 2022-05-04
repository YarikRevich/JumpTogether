using System.Collections.Generic;
using System.Collections;
using System.Text;

public static class URLCreator
{
    public static string Parse(string scheme, string host, string[] paths)
    {
        StringBuilder result = new StringBuilder();
        result.Append(scheme);
        result.Append("://");
        result.Append(host);
        foreach (string path in paths)
        {
            result.AppendFormat("/{0}", path);
        }
        return result.ToString();
    }
}