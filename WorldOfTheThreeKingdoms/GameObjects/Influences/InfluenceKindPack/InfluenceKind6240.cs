﻿using GameObjects;
using GameObjects.Influences;
using System;


using System.Runtime.Serialization;namespace GameObjects.Influences.InfluenceKindPack
{

    [DataContract]public class InfluenceKind6240 : InfluenceKind
    {
        private int increment;


        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.IncrementPerDayOfMorale += this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.IncrementPerDayOfMorale -= this.increment;
        }
    }
}

