using System.Collections.Generic;

namespace EF.Test.Entities
{
    public class Shop
    {
        public Shop()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
