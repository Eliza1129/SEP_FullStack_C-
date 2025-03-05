namespace Practice_Strings;

using System;

public class URLParser
{
    public static void ParseURL(string url)
    {
        string protocol = "";
        string server = "";
        string resource = "";

        // Check if URL contains "://", meaning it has a protocol
        int protocolIndex = url.IndexOf("://");
        if (protocolIndex != -1)
        {
            protocol = url.Substring(0, protocolIndex);
            url = url.Substring(protocolIndex + 3); 
        }

        // Find the server and resource 
        int resourceIndex = url.IndexOf("/");
        if (resourceIndex != -1)
        {
            server = url.Substring(0, resourceIndex);
            resource = url.Substring(resourceIndex + 1);
        }
        else
        {
            server = url; 
        }

        // Print the output
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}
