
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Net;
using System.Windows.Forms;
using System;

namespace VControlWClient
{
    //TODO convert to Asyncronous data transfer
    class VCServer : Server
    {

        private string data;
        public static List<Socket> users = new List<Socket>();
        private OnUpdateListener onUpdateListener;
        private bool permitted;

        public VCServer(int port, OnUpdateListener listener) : base(port)
        {
            base.port = port;
            onUpdateListener = listener;
            permitted = true;
        }

        public override void onClientConnected(Socket socket)
        {
            new Thread(delegate ()
            {
                socket.ReceiveTimeout = 10000;
                users.Add(socket);
                onUpdateListener.onNewConnection(((IPEndPoint)socket.RemoteEndPoint).Port, ((IPEndPoint)socket.RemoteEndPoint).Address.ToString());
                byte[] bytes = new byte[1024];
                int bytesRec = 0;
                try
                {
                    while (permitted && (bytesRec = socket.Receive(bytes)) > 0)
                    {
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        handleResponse(socket);
                        bytesRec = 0;
                    }
                }
                catch(SocketException e)
                {
                    Console.WriteLine(e.GetBaseException());
                }
                onClientDisconnected(socket);
            }).Start();
        }

        public void onClientDisconnected(Socket socket)
        {
               
            onUpdateListener.onConnectionClosed(users.IndexOf(socket));
            users.Remove(socket);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void handleResponse(Socket socket)
        {
            if (data.IndexOf("<EOF>") > -1)
            {
                if (!socket.Connected) return;
                data = data.Substring(0, data.Length - 6);
                VolRequestModel model = JsonConvert.DeserializeObject<VolRequestModel>(data);
                data = "";
                if (model.Req == 4)
                {
                    onClientDisconnected(socket);
                    return;
                }
                Utils.handleVol(model.Req, model.Increment);
            }
            else if (data.IndexOf("ping") > -1)
            {
                pingDevice(socket);
                data = "";
            }
        }

        public new void stopServer()
        {
            base.stopServer();
            permitted = false;

        }

        private void pingDevice(Socket socket)
        {
            try
            {
                socket.Send(Encoding.ASCII.GetBytes("response"));
            } catch
            {
                onClientDisconnected(socket);
                permitted = false;
            }
        }
    }
}