﻿using GameObjects;
using GameObjects.Influences;
using System;


using System.Runtime.Serialization;namespace GameObjects.Influences.InfluenceKindPack
{

    [DataContract]public class InfluenceKind6330 : InfluenceKind
    {
        private int increment;

        public override void ApplyInfluenceKind(Person person)
        {
            person.childrenStuntChanceIncrease += this.increment;
        }


        public override void PurifyInfluenceKind(Person person)
        {
            person.childrenStuntChanceIncrease -= this.increment;
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
    }
}
