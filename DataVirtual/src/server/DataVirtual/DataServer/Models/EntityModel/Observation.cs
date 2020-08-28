using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class Observation
    {
        [Key]
        public int ObsID { set; get; }

        public int? StudyID { set; get; }

        public string TumourType { set; get; }

        public string TumourSite { set; get; }

        public string ObsResult { set; get; }

        public decimal? pValue { set; get; }

        public string Operator { set; get; }

        public decimal? TD50_Gold { set; get; }

        public decimal? TD50_Lhasa { set; get; }

        [NotMapped]
        public List<DoseResp> DoseRespViews { set; get; }
    }
}
