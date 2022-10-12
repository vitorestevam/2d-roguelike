using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Completed
{
    public class CommandMove : Command { 

        private MovingObject obj;
        private int horizontal, vertical;


        public CommandMove(MovingObject obj, int horizontal, int vertical)
        {
            this.obj = obj;
            this.horizontal = horizontal;
            this.vertical = vertical;
        }
 
        public override void Execute() {
            obj.AttemptMove<Wall>(horizontal, vertical);
        }

        public override void Undo() { }
    }
}
