using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class ChemicalView
    {
        public string ChemID { set; get; }

        public string Mol_Block { set; get; }

        public decimal Mol_Weight { set; get; }

        public string Mol_Formula { set; get; }

        public List<StudyView> StudyViews { set; get; }
    }
}
