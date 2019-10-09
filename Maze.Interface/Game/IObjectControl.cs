using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Interface.Game
{
    public interface IObjectControl
    {


        void HandleEvent( ConsoleKeyInfo? key );

        void BeforeUpdate();


        void Update();

        void Render();
    }
}
