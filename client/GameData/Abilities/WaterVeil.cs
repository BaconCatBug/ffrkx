﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class WaterVeil : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30231031; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Ninja; } }
        public override SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.Water; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Magical; } }
        public override double Multiplier { get { return 21; } }
        public override string Name { get { return "Water Veil"; } }
        public override int Rarity { get { return 3; } }

        public override double MagicalDamage(double mag, double res)
        {
            return Math.Pow(mag, 0.825);
        }
    }
}
