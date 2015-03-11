using Dapper;

namespace EF.Test.Entities
{
    public enum EBikeType
    {
        Cross,
        Downhill,
        City,
        Szosowy
    }

    [Table("Bikes")]
    public class Bike:Product
    {
        public EBikeType EBikeType { get; set; }
    }
}
