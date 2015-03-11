using Dapper;

namespace EF.Test.Entities
{
    [Table("Tires")]
    public class Tire:Product
    {
        public int Size { get; set; }
    }
}
