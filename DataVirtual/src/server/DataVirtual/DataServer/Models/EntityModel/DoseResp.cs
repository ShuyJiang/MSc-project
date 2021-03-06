﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class DoseResp
    {
        [Key]
        public int DoseRespID { set; get; }

        public int? ObsID { set; get; }

        public decimal? Dose { set; get; }

        public string DoseUnit { set; get; }

        public int? TotalAnimals { set; get; }

        public int? WithTumours { set; get; }
    }
}
