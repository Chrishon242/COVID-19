using System;
using System.Net.Sockets;
using System.Net;


namespace Assets.Server.Script
{
    class Clients
    {
        public int connectionID;
        public string ip;
        public TcpClient socket;
        public NetworkStream myStream;
        private byte[] readBuffer;

        public void Start()
        {
            socket.SendBufferSize = 4096;
            socket.ReceiveBufferSize = 4096;
            myStream = socket.GetStream();
            readBuffer = new byte[4096];
            myStream.BeginRead(readBuffer, 0, socket.ReceiveBufferSize, ReceiveDataCallBack, null);
        }
        void ReceiveDataCallBack(IAsyncResult result)
        {
            try
            {
                int readbytes = myStream.EndRead(result);
                if (readbytes <= 0)
                {
                    return;
                }

                byte[] newBytes = new byte[readbytes];
                Buffer.BlockCopy(readBuffer, 0, newBytes, 0, readbytes);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
