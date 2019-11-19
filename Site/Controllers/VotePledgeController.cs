using Microsoft.AspNetCore.Mvc;
using ConstituencyLookup;
using ConstituencyLookup.LookupModels;
using DataAccess;
using DataAccess.Repositories;
using DatabaseModels;
using Site.Models;
using System.Collections.Generic;

namespace Site.Controllers
{
    public class VotePledgeController : Controller
    {
        private readonly ConstituencyRepository constituencyRepository;

        public VotePledgeController(ElectionContext electionContext)
        {
            this.constituencyRepository = new ConstituencyRepository(electionContext);
        }
        public IActionResult Index(string postcode)
        {
            ConstituencyQuery query = new ConstituencyQuery();
            ConstituencyResult constituencyResult = query.GetConstitutencyByPostCode(postcode);
            
            Constituency constituency = this.constituencyRepository.FindByName(constituencyResult.Name);
            ConstituencyViewModel vm = new ConstituencyViewModel()
            {
                Constituency = constituency,
                ConstituencyResult = constituencyResult,
            };
            return View(vm);
        }

        [HttpGet]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public ActionResult Addresses(string postcode)
        {
            AddressQuery addressQuery = new AddressQuery();
            IEnumerable<AddressResult> addressResults = addressQuery.GetAddressesByPostCode(postcode);
            return Json(addressResults);
        }
    }
}