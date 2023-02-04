using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern;

namespace CommandPattern.commands
{
    public class SlowDown : Command
    {
        private MoveObject moveObject;

        public SlowDown(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }


        public override void Execute()
        {
            moveObject.SlowDown();
        }
    }
}
