using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern;

namespace CommandPattern.commands
{
    public class StrafeRight : Command
    {
        private MoveObject moveObject;


        public StrafeRight(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }

        public override void Execute()
        {
            moveObject.StrafeRight();
        }
    }
}
