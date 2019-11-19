using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels
{
    public class Constituency : IEntity<short>
    {
        [Key]
        public short Id { get; set; }

        [Display(Name = "Constituency Name")]
        public string Name { get; set; }

        [Display(Name = "Candidates")]
        public virtual ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
