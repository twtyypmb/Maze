using Maze.Implementation.Game;
using Maze.Interface.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maze.Game
{
    public class GameObject:Entity.Data.Element, IObjectControl
    {
        IEngine engine = null;
        public GameObject( IEngine _engine )
        {
            engine = _engine;
        }

        public virtual void BeforeUpdate()
        {
            engine.ClearSomewhere( this );
        }

        ConsoleKeyInfo? key = null;
        bool need_render = false;

        public virtual void HandleEvent()
        {
            key = engine.GetKey();
        }

        public virtual void Render()
        {
            engine.RenderObject( this );
        }

        public virtual void Update()
        {
            if( key == null )
            {
                return;
            }


        }

        public virtual int Velocity
        {
            get;set;
        }
    }
}
