﻿using GameObjects;
using GameObjects.Conditions;
using System;


using System.Runtime.Serialization;namespace GameObjects.Conditions.ConditionKindPack
{

    [DataContract]public class ConditionKind2705 : ConditionKind
    {
        private int val;

        public override bool CheckConditionKind(Architecture a)
        {
            return a.Kind.ID != val;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }


    }
}

