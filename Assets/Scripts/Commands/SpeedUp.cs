using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CommandPattern;

namespace CommandPattern.commands
{
    public class SpeedUp : Command
    {
        private MoveObject moveObject;


        public SpeedUp(MoveObject moveObject)
        {
            this.moveObject = moveObject;
        }


        public override void Execute()
        {
            moveObject.SpeedUp();
        }
    }
}
