using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern;

namespace CommandPattern.commands
{
    public class StrafeLeft : Command
    {
        private MoveObject moveObject;


        public StrafeLeft(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }


        public override void Execute()
        {
            moveObject.StrafeLeft();
        }
    }
}