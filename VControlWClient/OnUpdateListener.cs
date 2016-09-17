using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VControlWClient
{
    interface OnUpdateListener
    {
        void onNewConnection(int port, string ipAddr);
        void onConnectionClosed(int index);
    }
}
