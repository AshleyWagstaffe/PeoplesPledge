using System.Collections.Generic;
using System.Linq;
using DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ConstituencyRepository : IRepository<Constituency, short>
    {
        private readonly ElectionContext electionContext;

        public ConstituencyRepository(ElectionContext electionContext)
        {
            this.electionContext = electionContext;
        }

        public IEnumerable<Constituency> List => electionContext.Constituencies;

        public void Add(Constituency entity)
        {
            this.electionContext.Constituencies.Add(entity);
        }

        public void Delete(Constituency entity)
        {
            this.electionContext.Constituencies.Remove(entity);
        }

        public Constituency FindById(short id)
        {
            return this.electionContext.Constituencies.Include(c => c.Candidates).Where(c => c.Id == id).FirstOrDefault();
        }

        public Constituency FindByName(string name)
        {
            return this.electionContext.Constituencies.Include(c => c.Candidates).ThenInclude(can => can.Party).Where(c => EF.Functions.Like(c.Name, $"%{name}%")).FirstOrDefault();
        }

        public void Update(Constituency entity)
        {
            this.electionContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
