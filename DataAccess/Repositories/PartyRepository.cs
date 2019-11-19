using System.Collections.Generic;
using System.Linq;
using DatabaseModels;

namespace DataAccess.Repositories
{
    public class PartyRepository : IRepository<Party, byte>
    {
        private readonly ElectionContext electionContext;

        public PartyRepository(ElectionContext electionContext)
        {
            this.electionContext = electionContext;
        }

        public IEnumerable<Party> List => electionContext.Parties;

        public void Add(Party entity)
        {
            this.electionContext.Parties.Add(entity);
        }

        public void Delete(Party entity)
        {
            this.electionContext.Parties.Remove(entity);
        }

        public Party FindById(byte id)
        {
            return this.electionContext.Parties.Where(c => c.Id == id).FirstOrDefault();
        }

        public Party FindByName(string name)
        {
            return this.electionContext.Parties.Where(c => c.Name.Equals(name, System.StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
        }

        public void Update(Party entity)
        {
            this.electionContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
