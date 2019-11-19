using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace DatabaseModels
{
    public class Party : IEntity<byte>
    {
        [Key]
        public byte Id { get; set; }

        [Display(Name = "Party Name")]
        public string Name { get; set; }

        [Display(Name = "Candidates")]
        public virtual ICollection<Candidate> Candidates { get; set; } = new List<Candidate>();
    }
}
