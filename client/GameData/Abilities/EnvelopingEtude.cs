﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.Abilities
{
    class EnvelopingEtude : FFRKInspector.GameData.Ability
    {
        public override uint AbilityId { get { return 30241041; } }
        public override SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.Bard; } }
        public override string Name { get { return "Enveloping Etude"; } }
        public override int Rarity { get { return 4; } }
    }
}
