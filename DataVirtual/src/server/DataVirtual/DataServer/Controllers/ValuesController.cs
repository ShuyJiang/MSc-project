using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataServer.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace DataServer.Controllers
{
    [EnableCors("AllowAllDomain")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CoreDbContext coreDb;

        public ValuesController(CoreDbContext context)
        {
            coreDb = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Chemical>> Get(string chemicalid)
        {
            ResultModel result = new ResultModel();
            ChemicalView chemicalView = new ChemicalView();
            if (string.IsNullOrEmpty(chemicalid))
            {
                result.code = 4000;
                result.msg = "Query keyword cannot be empty";  //Validation is not empty
                return BadRequest(result);
            }
            //Verify the validity of the data from the front desk and determine whether the compound exists
            Chemical chemical = coreDb.Chemical.Where(t => t.ChemID == chemicalid).FirstOrDefault();
            if(chemical == null)
            {
                // not find
                result.code = 2000;
                result.msg = "The query was successful, but no results were found";
                return Ok(result);
            }
            //All experiments were obtained through ChemID
            var studylist = coreDb.Study.Where(t => t.ChemID == chemicalid);
            chemical.StudyViews = studylist.ToList();
            // Traverse the obtained experiment to find the observation record of each experiment
            for (int i = 0; i < chemical.StudyViews.Count; i++)
            {
                var studyitem = chemical.StudyViews[i];
                var temptest = coreDb.Observation.Where(t => t.StudyID == studyitem.StudyID).ToList();
                chemical.StudyViews[i].ObservationViews = coreDb.Observation.Where(t => t.StudyID == studyitem.StudyID).ToList();
                for (int j = 0; j < chemical.StudyViews[i].ObservationViews.Count; j++)
                {
                    var obsitem = chemical.StudyViews[i].ObservationViews[j];
                    chemical.StudyViews[i].ObservationViews[j].DoseRespViews = coreDb.DoseResp.Where(t => t.ObsID == obsitem.ObsID).OrderBy(o => o.Dose).ToList();
                }
            }
            result.code = 2001;
            result.msg = "success";
            result.chemical = chemical;
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
