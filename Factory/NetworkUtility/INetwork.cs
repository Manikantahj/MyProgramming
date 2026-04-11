using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgramming.Factory.NetworkUtility
{
    internal interface INetwork
    {
        void SendRequest(string ip, int timesent);
    }
}
