using EF.Test.Entities.TPH;

namespace EF.Test.Entities
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int ShopId { get; set; }
        public virtual Shop Shop { get; set; }

    }
}
