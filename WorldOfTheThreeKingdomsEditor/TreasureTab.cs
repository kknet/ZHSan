﻿using GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WorldOfTheThreeKingdomsEditor
{
    class TreasureTab : BaseTab<Treasure>
    {
        protected override GameObjectList GetDataList(GameScenario scen)
        {
            return scen.Treasures;
        }

        protected override Dictionary<string, string> GetDefaultValues()
        {
            return new Dictionary<string, string>()
            {
                {"HidePlace", "-1"},
                {"BelongedPerson", "-1" }
            };
        }

        protected override string[] GetRawItemOrder()
        {
            return new String[]
            {
                "ID",
                "Name",
                "Pic",
                "Worth",
                "Available",
                "HidePlaceIDString",
                "TreasureGroup",
                "AppearYear",
                "BelongedPersonIDString",
                "InfluencesString",
                "Description"
            };
        }

        public TreasureTab(GameScenario scen, DataGrid dg)
        {
            init(scen, dg);
        }
    }
}
