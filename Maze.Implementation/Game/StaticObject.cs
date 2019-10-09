using Maze.Entity.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Implementation.Game
{
    public static class StaticObject
    {
        public static readonly Element NullElement = new Element();

        public static void ClearSomewhere( Element element )
        {
            NullElement.Position = element.Position;

        }
    }
}
