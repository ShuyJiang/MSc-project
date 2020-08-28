using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class ObservationView
    {
        public int ObsID { set; get; }

        public int StudyID { set; get; }

        public string TumourType { set; get; }

        public string TumourSite { set; get; }

        public string ObsResult { set; get; }

        public decimal pValue { set; get; }

        public string Operator { set; get; }

        public decimal TD50_Gold { set; get; }

        public decimal TD50_Lhasa { set; get; }
        
        public List<DoseRespView> DoseRespViews { set; get; }
    }
}
