using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Controller_Server 
{
    class ServerHandle
    {
        public static void WelcomeRecieved(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            string _username = _packet.ReadString();

            Console.WriteLine($"{Server.client.tcp.socket.Client.RemoteEndPoint} connected successfully!");
            if(_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player \"{_username}\" (ID: {_fromClient} has assumed the wrong client ID ({_clientIdCheck})");
            }

            Server.client.ConnectController();
        }
    }
}