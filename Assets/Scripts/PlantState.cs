using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlantState
{
    public abstract class PlantState
    {
        public abstract void Improve();

        public abstract void Degrade();
    }
}
