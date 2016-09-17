using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace VControlWClient
{
    interface OnClientListener
    {
        void onClientConnected(Socket socket);
    }
}
