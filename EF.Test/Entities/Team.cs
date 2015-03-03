using System.Collections.Generic;

namespace EF.Test.Entities
{
    public class Team
    {
        public Team()
        {
            Members=new List<Member>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
