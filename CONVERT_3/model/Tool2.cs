using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONVERT_3.model
{
    public class Tool2
    {
        public List<float> list { get; set; }
        
        public string ID { get; set; }
        public string Description { get; set; }
        public string CutterName { get; set; }
        public string Holdername { get; set; }
        public string Type { get; set; }
        public  string  D { get; set; }
        public string A { get; set; }

        public string H { get; set; }
        public string R { get; set; }
        public string FluteLength { get; set; }
        public string SharkDiameter { get; set; }

        public Holder holder2 { get; set; }
    }
}