using System;
using System.Collections.Generic;
using System.Text;

namespace Controller_Server
{
    class GameLogic
    {
        public static void Update()
        {
            Client _client = Server.client;

            if (_client.player != null)
            {
                _client.player.Update();
            }

            ThreadManager.UpdateMain();
        }
    }
}