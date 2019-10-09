using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Interface.Game
{
    public interface IObjectControl
    {
        void HandleEvent();
        void Update();
        void Render();
    }
}
