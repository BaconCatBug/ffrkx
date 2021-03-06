﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData.SoulBreaks
{
    class Shadowbringer : FFRKInspector.GameData.SoulBreak
    {
        public override uint SoulBreakId { get { return 20060006; } }
        public override SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DARK_CECIL; } }
        public override SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.Physical; } }
        public override double Multiplier { get { return 1.53; } }
        public override string Name { get { return "Shadowbringer"; } }
        public override int NumberOfHits { get { return 6; } }
    }
}
