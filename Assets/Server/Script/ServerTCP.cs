using System;
using System.Net.Sockets;
using System.Net;

namespace Assets.Server.Script
{  /*
   public  class ServerTCP
    {
        public static TcpListener serverSocket;
        public Clients[] Client = new Clients[1500];

        public void InitNetwork()
        {
            serverSocket = new TcpListener(IPAddress.Any, 5555);
            serverSocket.Start();
        }

        private void ClientConnectCallback(IAsyncResult result)
        {
            TcpClient tempClient = serverSocket.EndAcceptTcpClient(result);
            serverSocket.BeginAcceptTcpClient(ClientConnectCallback, null);
            Console.WriteLine("Player Succesfully connected.");
            for (int i = 0; i < Client.Length; i++)
            {
                if (Client[i].socket == null)
                {
                    Client[i].socket = tempClient;
                    Client[i].connectionID = i;
                    Client[i].ip = tempClient.Client.RemoteEndPoint.ToString();
                    Client[i].Start();
                    Console.WriteLine("Connection recevied from " + Client[i].ip + ".");
                    return;
                }
            }
        }
    }*/
}
