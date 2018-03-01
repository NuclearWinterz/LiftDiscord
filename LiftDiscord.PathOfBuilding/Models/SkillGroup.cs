﻿namespace LiftDiscord.PathOfBuilding.Models
{
    using System.Collections.Generic;
    using System.Linq;

    public class SkillGroup
    {
        public SkillGroup(IEnumerable<Gem> gems, string slot, bool isEnabled, bool isSelectedGroup)
        {
            IsSelectedGroup = isSelectedGroup;
            IsEnabled = isEnabled;
            Slot = slot;
            Gems = gems.ToList();
        }

        public bool IsSelectedGroup { get; }
        public bool IsEnabled { get; }
        public string Slot { get; }
        public IReadOnlyList<Gem> Gems { get; }
    }
}
