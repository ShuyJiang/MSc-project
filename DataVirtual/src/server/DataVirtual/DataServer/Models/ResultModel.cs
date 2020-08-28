using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataServer.Models
{
    public class ResultModel
    {
        public int code { set; get; }

        public string msg { set; get; }

        public Chemical chemical { set; get;  }
    }
}
