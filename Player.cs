using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace Controller_Server
{
    class Player 
    {

        private XInputController controller;

        public Player()
        {
            controller = new XInputController();
        }

        public void Update()
        {
            controller.Update();
            Move();
        }

        public void Move()
        {
            float[] _inputs = new float[]
            {
                controller.leftThumb.x,
                controller.leftThumb.y,
                controller.rightThumb.x,
                controller.rightThumb.y,
            };

            ServerSend.ControllerInputs(_inputs);
        }
    }
}