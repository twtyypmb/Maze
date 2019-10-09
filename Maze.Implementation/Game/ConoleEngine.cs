using Maze.Entity.Data;
using Maze.Interface.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Implementation.Game
{
    public class ConoleEngine : IEngine
    {
        public bool IsRunning
        {
            get;private set;
        }

        public void ClearSomewhere( Element element )
        {
            StaticObject.ClearSomewhere( element );
        }

        public ConsoleKeyInfo? GetKey()
        {
            if( Console.KeyAvailable )
            {
               return Console.ReadKey( true );
            }

            return null;
        }

        public void RenderObject( Element element )
        {
            Console.SetCursorPosition( element.Position.X, element.Position.Y );
            Console.Write( element.Image );
        }

        public bool Start()
        {
            IsRunning = true;
            return IsRunning;
        }

        public bool Stop()
        {
            IsRunning = false;
            return true;
        }

    }
}
