using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace VControlWClient
{
    abstract class Server
    {
        protected int port;
        private bool permitted = true;
        public Server(int port)
        {
            this.port = port;
        }

        public void initializeServer()
        {
            new Thread(delegate ()
             {
                 IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, port);
                 Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                 try
                 {
                     listener.Bind(localEndPoint);
                     listener.Listen(10);
                     while (permitted)
                     {
                         Socket socket = listener.Accept();
                         onClientConnected(socket);
                     }
                 }
                 catch (Exception e)
                 {
                     Console.WriteLine(e.ToString());
                 }
             }
             ).Start();
        }

        public abstract void onClientConnected(Socket socket);

        public void startServer()
        {
            initializeServer();
        }

        public void stopServer()
        {
            permitted = false;
        }
    }
}