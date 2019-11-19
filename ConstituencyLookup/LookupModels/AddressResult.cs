namespace ConstituencyLookup.LookupModels
{
    public class AddressResult
    {
        public string FirstLine { get; set; }

        public string Postcode { get; set; }

        public override bool Equals(object obj)
        {
            return obj is AddressResult result &&
                   FirstLine == result.FirstLine &&
                   Postcode == result.Postcode;
        }

        public int HashCode => GetHashCode();

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 486187739 + FirstLine.GetHashCode();
                hash = hash * 486187739 + Postcode.GetHashCode();
                return hash;
            }
        }
    }
}
