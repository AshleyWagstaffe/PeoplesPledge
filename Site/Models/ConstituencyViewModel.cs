using ConstituencyLookup.LookupModels;
using DatabaseModels;
using System.Collections.Generic;
using System.Linq;

namespace Site.Models
{
    public class ConstituencyViewModel
    {
        public ConstituencyResult ConstituencyResult { get; set; }

        public Constituency Constituency { get; set; }

        public string Name => ConstituencyResult.Name;

        public string Postcode => ConstituencyResult.PostCode;

        public List<Candidate> Candidates => Constituency.Candidates.ToList();
    }
}
