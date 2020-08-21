using System;
using System.Collections.Generic;
using System.Text;

namespace Controller_Server
{
    class ServerSend
    {
        private static void SendTCPData(Packet _packet)
        {
            _packet.WriteLength();
            Server.client.tcp.SendData(_packet);
        }

        private static void SendUDPData(Packet _packet)
        {
            _packet.WriteLength();
            Server.client.udp.SendData(_packet);
        }

        public static void Welcome(int _toClient, string _msg)
        {
            using (Packet _packet = new Packet((int)ServerPackets.welcome))
            {
                _packet.Write(_msg);
                _packet.Write(_toClient);

                SendTCPData(_packet);
            }
        }

        public static void ControllerInputs(float[] _inputs)
        {
            using (Packet _packet = new Packet((int)ServerPackets.controllerInputs))
            {
                foreach (float _input in _inputs)
                {
                    _packet.Write(_input);
                }

                SendUDPData(_packet);
            }
        }
    }
}