using System.Collections.Generic;
using System.Linq;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class CandidateRepository : IRepository<Candidate, int>
    {
        private readonly ElectionContext electionContext;

        public CandidateRepository(ElectionContext electionContext)
        {
            this.electionContext = electionContext;
        }

        public IEnumerable<Candidate> List => electionContext.Candidates;

        public void Add(Candidate entity)
        {
            this.electionContext.Candidates.Add(entity);
        }

        public void Delete(Candidate entity)
        {
            this.electionContext.Candidates.Remove(entity);
        }

        public Candidate FindById(int id)
        {
            return this.electionContext.Candidates.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Candidate> FindByNameContains(string search)
        {
            return this.electionContext.Candidates.Where(c => EF.Functions.Like(c.Name, $"%{search}%"));
        }

        public void Update(Candidate entity)
        {
            this.electionContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
