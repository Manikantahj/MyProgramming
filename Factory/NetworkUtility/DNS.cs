using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.Factory.NetworkUtility
{
    internal class DNS : INetwork
    {      
        public void SendRequest(string ip, int timesent)
        {
            Console.WriteLine("DNS request sent to " + ip + "" + timesent + "times");
        }
    }
}
