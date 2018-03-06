using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String strHostName = Dns.GetHostName();

            Console.WriteLine("Host Name: " + strHostName);
          //  IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            int nIP = 0;
            IPHostEntry iphostentry = Dns.Resolve(strHostName);
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                Console.WriteLine("IP #" + ++nIP + ": " +
                                  ipaddress.ToString());
            }
            Console.ReadLine();
        }
    }
}
