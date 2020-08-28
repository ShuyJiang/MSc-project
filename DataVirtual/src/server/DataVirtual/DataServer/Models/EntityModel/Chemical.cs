using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class Chemical
    {
        [Key]
        public string ChemID { set; get; }

        [MaxLength(10000,ErrorMessage = "The data is too long")]
        public string Mol_Block { set; get; }

        public decimal? Mol_Weight { set; get; }

        [MaxLength(40, ErrorMessage = "The data is too long")]
        public string Mol_Formula { set; get; }

        [NotMapped]
        public List<Study> StudyViews { set; get; }
    }
}
