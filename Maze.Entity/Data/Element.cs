using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Maze.Entity.Data
{
    public class Element
    {
        public Point Position
        {
            get; set;
        }

        public Size Size
        {
            get; set;
        }

        public string Image { get; set; } = "  ";


    }
}
