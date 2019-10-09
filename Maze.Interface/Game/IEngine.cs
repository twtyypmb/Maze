using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Interface.Game
{
    public interface IEngine
    {
        bool Start();

        ConsoleKeyInfo? GetKey();

        void RenderObject( Maze.Entity.Data.Element element );

        void ClearSomewhere( Maze.Entity.Data.Element element );

        bool Stop();

        bool IsRunning
        {
            get;
        }
    }
}
