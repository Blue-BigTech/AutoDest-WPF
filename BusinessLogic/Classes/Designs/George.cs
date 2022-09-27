﻿using System.Collections.Generic;

namespace BusinessLogic.Classes.Designs

{
    public class George : Design
    {
        public override string Name { get; set; } = "George";
        public sealed override double NumberOfHorizontalProfileGroups { get; set; } = 0;
        public override double NumberOfVerticalProfileGroups { get; set; } = 0;
        public override double NumberOfGlassPanels { get; set; } = 1;
        public override double NumberOfSteelPlates { get; set; } = 0;
        public override bool CanBeMirrored { get; set; }
        public override bool IsBottomGlassCustom { get; set; }

        public George()
        {
            
        }

        public George(Data data, ConstructionOpening co, double doorHeight)
        {
            
        }

        public override void CalculateSidelightDesign(Element element, Data data, Dictionary<string, string> clientElementProfiles)
        {
            
        }

        public override void CalculateDoorDesign(Element element, Data data, Dictionary<string, string> clientElementProfiles)
        {
            
        }
    }
}