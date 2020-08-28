using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class Study
    {
        [Key]
        public int StudyID { set; get; }

        public string ChemID { set; get; }

        public string Species { set; get; }

        public string Strain { set; get; }

        public string Sex { set; get; }

        public decimal? Exposure_Time { set; get; }

        public string Exposure_Unit { set; get; }

        public decimal? Experiment_Time { set; get; }

        public string Experiment_Unit { set; get; }

        public string Route { set; get; }

        public string Notes { set; get; }

        [NotMapped]
        public List<Observation> ObservationViews { set; get; }
    }
}
