using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Game
{
    public class GameObject:Entity.Data.Element, Interface.Game.IObjectControl
    {
        Interface.Game.IObjectControl control = null;
        public GameObject(Interface.Game.IObjectControl _control)
        {
            control = _control;
        }

        public void HandleEvent()
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
