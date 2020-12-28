using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

public class DomainToIp : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(DoGetHostAddresses("127.0.0.1"));

    }

    public void Domain2Ip(string domain)
    {
        Dns.GetHostAddresses(domain);
        Dns.GetHostName();
    }


    public static string  DoGetHostAddresses(string hostname)
    {
        if (System.Net.IPAddress.TryParse(hostname, out IPAddress iP))
        {
            return hostname;
        }

        IPAddress[] ips;
        ips = Dns.GetHostAddresses(hostname);
        return ips[0].ToString();
    }
}
