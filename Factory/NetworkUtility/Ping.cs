using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.Factory.NetworkUtility
{
    internal class Ping : INetwork
    {     
        public void SendRequest(string ip, int timesent)
        {
            Console.WriteLine("Ping request sent to " + ip + "" + timesent + "times");
        }
    }
}
