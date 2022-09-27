﻿using BusinessLogic.Settings;

namespace BusinessLogic.Classes.Handles
{
    public class Ror_R : Handle
    {
        public string Name { get; set; } = "Ror_R";
        public int NumberOfAdapters { get; set; } = 2;
        public bool HasRoundHandle { get; set; } = true;
        public bool NeedsHandlePlate { get; set; } = true;
        public bool IsAdapterFulGripHeight { get; set; }
        public double WallThickness { get; set; } = GlobalSettings.DafaultHandleWallThickness;
        public double GripWidth { get; set; } = 21;
        public double GripThickness { get; set; } = 21;
        public double GripExtension { get; set; }
        public double HandleOffsetFromAdapter { get; set; }
        public double AdapterWidth { get; set; } = 21;
        public double AdapterHeight { get; set; } = 21;
        public double AdapterThickness { get; set; } = 40;
        
        public Ror_R()
        {
            
        }
        
        public Ror_R(Element element, Data data, ConstructionOpening co) { }
        
        public HandleTopView CalculateTopView(Element element)
        {
            HandleTopView handleTopView = new HandleTopView();
            
            return handleTopView;
        }
    }
}