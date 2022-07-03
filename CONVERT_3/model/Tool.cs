using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERT_3.model
{
    public class Tool
    {
        public string ID { get; set; }
        public string CutterName { get; set; }
        public string Tech { get; set; }
        public string Type { get; set; }
        public string Comment { get; set; }
        //public string Website { get; set; }
        //public string MagazineNo { get; set; }
        //public string DiameterCompensation { get; set; }
        //public string LengthCompensation { get; set; }
        public string Technology { get; set; }
        //public string TipType { get; set; }
        //public string CatalogName { get; set; }
        //public string ThreadType { get; set; }
        public string Diameter { get; set; }
        public string CornerRadius { get; set; }
        //public string UseFullCutterLength { get; set; }
        //public string FullCutterLength { get; set; }
        public string ClearLength { get; set; }
        public string CutLength { get; set; }
        //public string Taper { get; set; }
        public string TaperAngle { get; set; }
        //public string TipAngle { get; set; }
        //public string Shank { get; set; }
        //public string ShankTopDiameter { get; set; }
        //public string ShankBottomDiameter { get; set; }
        //public string ShankConeLength { get; set; }
        //public string UseShankConeAngle { get; set; }
        //public string ShankConeAngle { get; set; }
        //public string ShankFreeLength { get; set; }
        public string HolderName { get; set; }
        //public string GripLength { get; set; }
        //public string FreeLength { get; set; }
        //public string Feed { get; set; }
        //public string Spin { get; set; }
        //public string Vc { get; set; }
        //public string Fz { get; set; }
        //public string Pitch { get; set; }
        public string Teeth { get; set; }
        //public string PlungeFeed { get; set; }
        //public string SpindleDir { get; set; }
        //public string LifeLength { get; set; }
        //public string Coolant { get; set; }
        //public string GaugeLength { get; set; }
        //public string CornerFeed { get; set; }
        //public string DownFeed { get; set; }
        //public string SideFeed { get; set; }
        //public string DZFeed { get; set; }
        //public string EntryFeed { get; set; }
        //public string EndFeed { get; set; }
        //public string RetractFeed { get; set; }
        //public string DownStep { get; set; }
        //public string SideStep { get; set; }
        //public string ForwardStep { get; set; }
        //public string AppRadius { get; set; }
        //public string AppLength { get; set; }
        //public string Tolerance { get; set; }
        //public string Connectto { get; set; }
        //public string CuttingMode { get; set; }
        //public string CollapseDirection { get; set; }
        //public string PlungeSize { get; set; }
        //public string RampAngle { get; set; }
        //public string DZFeedStart { get; set; }
        //public string Cycle { get; set; }
        //public string Shift { get; set; }
        //public string ShiftI { get; set; }
        //public string ShiftJ { get; set; }
        //public string Dwell { get; set; }
        //public string DwellTime { get; set; }
        //public string Peck { get; set; }
        //public string PeckStep { get; set; }
        //public string PeckDec { get; set; }
        //public string Misc1 { get; set; }
        //public string Misc2 { get; set; }
        //public string Misc3 { get; set; }
        //public string Misc4 { get; set; }

        public Holder holder { get; set; }
        public string getTechnology()
        {
            switch (Technology)
            {
                case "210102": return "Drilling"; break;
                case "210103": return "Special Lollipop"; break;
                case "210104": return "Special Slot Mill"; break;
                case "210105": return "Special Dove Mill"; break;
                case "210106": return "Special Counter Sink"; break;
                default: return "Milling";
            }
        }

        //public string getType()
        //{
        //    switch (TipType)
        //    {
        //        case "210202": return "Ball"; break;
        //        case "210203": return "Bull"; break;
        //        case "210204": return "Drilling"; break;
        //        case "210205": return "Ream"; break;
        //        case "210206": return "Tap"; break;
        //        case "210207": return "Center"; break;
        //        case "210208": return "Full Radius"; break;
        //        case "210209": return "Concer Radius"; break;
        //        default: return "Flat";
        //    }
        //}

    }
}
