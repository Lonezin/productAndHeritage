namespace Imported_Products.Entities
{
    public class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }
        
        public UsedProduct ()
        {

        }
        public UsedProduct (string name, double price, DateTime manufacturedate) : base (name, price )
        {
            ManuFactureDate = manufacturedate;
        }
        public override string PriceTag()
        {
            return Name + " (used) $" + Price + " (Manufacture date: " +  ManuFactureDate.ToString("dd/MM/yyy") + ")";
        }
    }
}