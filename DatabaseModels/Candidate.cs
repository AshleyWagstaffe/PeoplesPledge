using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseModels
{
    public class Candidate : IEntity<int>
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Prefix")]
        public string HonorificPrefix { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Suffix")]
        public string HonorificSuffix { get; set; }

        [Display(Name = "Party")]
        public virtual Party Party { get; set; }

        public byte PartyId { get; set; }

        [Display(Name = "Constituency")]
        public virtual Constituency Constituency { get; set; }

        public short ConstituencyId { get; set; }

        [Display(Name = "Twitter Handle")]
        public string TwitterUsername { get; set; }

        [Display(Name = "Official FB")]
        public string FacebookUrl { get; set; }

        [Display(Name = "Personal FB")]
        public string FacebookPersonalUrl { get; set; }

        [Display(Name = "Instagram Handle")]
        public string InstagramUrl { get; set; }

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

        [Display(Name = "Has Signed Labour Pledge?")]
        public bool? HasSignedLabourPledge { get; set; }

        [Display(Name = "Date Submitted People's Pledge")]
        public DateTime? DatePeoplePledgeRegistered { get; set; }

        [Display(Name = "Date People's Pledge Verified")]
        public DateTime? DatePeoplesPledgeVerified { get; set; }

        [Display(Name = "Was Elected?")]
        public bool Elected { get; set; }

        [Display(Name = "Verification Contact Details")]
        public string VerificationContactDetails { get; set; }
    }
}
